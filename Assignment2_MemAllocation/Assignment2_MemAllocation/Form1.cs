using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_MemAllocation
{
    public partial class Memory_Allocation : Form
    {
        //private Memory Memory;
        //Memory Block = new Memory();
        public Memory_Allocation()
        {
            InitializeComponent();
        }

        /** Algorithm Instance **/
        //LinkedList<Memory_Element> Mem_Layout = new LinkedList<Memory_Element>();
        SortedList<int,Memory_Element> Mem_Layout = new SortedList<int,Memory_Element>();
        LinkedList<Memory_Element> Processes = new LinkedList<Memory_Element>();
        LinkedList<Memory_Element> Waiting_Processes = new LinkedList<Memory_Element>();

        int memory_size, holes_number;
        int ready_processes_number = 0, waiting_processes_number = 0;
        int mem_total_elements = 0;
        int reserved = 0;


        /** Holes Input Tab **/
        private void btn_size_number_ok_Click(object sender, EventArgs e)
        {
            memory_size = Convert.ToInt32(txtBox_memory_size.Text);
            holes_number = Convert.ToInt32(txtBox_holes_number.Text);
            mem_total_elements = holes_number;

            //A.setup_memory(Convert.ToInt32(txtBox_memory_size.Text), Convert.ToInt32(txtBox_holes_number.Text));
            txtBox_memory_size.Enabled = false;
            txtBox_holes_number.Enabled = false;
            btn_size_number_ok.Enabled = false;
            //txtBox_holes_info.Text = memory_size.ToString() + " " + holes_number.ToString();
        }

        private void btn_size_number_cancel_Click(object sender, EventArgs e)
        {
            txtBox_memory_size.Enabled = true;
            txtBox_holes_number.Enabled = true;
            btn_size_number_ok.Enabled = true;
            btn_mem_update.Enabled = true;
            if (txtBox_holes_info.Enabled == false)
            {
                txtBox_holes_info.Enabled = true;
            }
        }

        private void btn_mem_update_Click(object sender, EventArgs e)
        {
            if(btn_size_number_ok.Enabled == false)
            {
                Mem_Layout.Clear();
                string[] All_Lines = txtBox_holes_info.Text.Split('\n');
                foreach(string text in All_Lines)
                {
                    string[] Hole_Parameters = text.Split(',');
                    int hole_size = Convert.ToInt32(Hole_Parameters[0]);
                    int hole_starting_address = Convert.ToInt32(Hole_Parameters[1]);
                    // Mem_Layout.AddLast(new Memory_Element("hole", "hole",
                    //   Convert.ToInt32(Hole_Parameters[0]), Convert.ToInt32(Hole_Parameters[1])));
                    Mem_Layout.Add(hole_starting_address, 
                        new Memory_Element("hole", 'h', hole_size, hole_starting_address));
                }
                txtBox_holes_info.Enabled = false; //close on current holes
                /*for(int i = 0; i < holes_number; i++)
                {
                    // txtBox_holes_info.AppendText(Mem_Layout[i].starting_address.ToString() + " " +
                      // Mem_Layout[i].size.ToString() + "\n");
                    txtBox_holes_info.AppendText( Mem_Layout.ElementAt(i).Value.starting_address.ToString() +"\n");
                }*/



                /** Updating Memory with Reserved Space **/
                
                SortedList<int, Memory_Element> Reserved_Space =
                    new SortedList<int, Memory_Element>();
                int reserved_number = 0;
                for(int i = 0; i < mem_total_elements; i++)
                {
                    if(i == 0)
                    {
                        int first_space = Mem_Layout.ElementAt(i).Key;
                        //int first_size = Mem_Layout.ElementAt(i).Value.size;
                            //+ Mem_Layout.ElementAt(i).Value.size;
                        if(first_space > 0)
                        {
                            reserved_number++;
                            Reserved_Space.Add(0, new Memory_Element(
                                "reserved", 'r', first_space, 0));
                        }
                    }
                    else
                    {
                        int prev_starting_address =
                            Mem_Layout.ElementAt(i - 1).Key +
                            Mem_Layout.ElementAt(i - 1).Value.size;

                        int reserved_size =
                            Mem_Layout.ElementAt(i).Key - prev_starting_address;

                        if (Mem_Layout.ElementAt(i).Key > prev_starting_address)
                        {
                            reserved_number++;
                            Reserved_Space.Add(prev_starting_address,
                                new Memory_Element("reserved", 'r',
                                reserved_size, prev_starting_address));
                        }
                        /** Testing the remaining memory case **/
                        if (i == (mem_total_elements - 1))
                        {
                            int last_space = Mem_Layout.ElementAt(i).Key
                                + Mem_Layout.ElementAt(i).Value.size;
                            if (last_space < memory_size)
                            {
                                reserved_number++;
                                Reserved_Space.Add(last_space, new Memory_Element(
                                    "reserved", 'r', memory_size - last_space, last_space));
                            }
                        }
                    }
                }
                reserved = reserved_number;
                for(int i = 0; i < reserved_number; i++)
                {
                    Mem_Layout.Add(Reserved_Space.ElementAt(i).Key,
                        Reserved_Space.ElementAt(i).Value);

                    mem_total_elements++;

                    Reserved_Space.RemoveAt(i);
                    reserved_number--;
                    i = -1;
                }
                

                /** Saving Settings for Memory Update **/
                btn_mem_update.Enabled = false;

            }
        }

        /** Processes Input Tab **/

        private void btn_Allocation_Click(object sender, EventArgs e)
        {
            if (btn_mem_update.Enabled == false)
            {
                Processes.Clear();
                ready_processes_number = 0;
                
                if(!chk_De_Allocate.Checked)
                {
                    //Processes.Clear();
                    string[] All_Lines = txtBox_pocesses_info.Text.Split('\n');
                    foreach (string text in All_Lines)
                    {
                        string[] Process_Paramteres = text.Split(',');
                        string process_name = Process_Paramteres[0];
                        int process_size = Convert.ToInt32(Process_Paramteres[1]);
                        Processes.AddLast(new Memory_Element(process_name, 'p',
                           size: process_size));

                        ready_processes_number++;
                    }
                    
                }
                else
                {
                    string[] All_Lines = txtBox_pocesses_info.Text.Split('\n');
                    foreach (string text in All_Lines)
                    {
                        Processes.AddLast(new Memory_Element(text, 'p',0,0));
                        ready_processes_number++;
                    }
                }


                if (chk_first_fit.Checked) //First Fit Algorithm
                {
                    //search for first partition suitable for process
                    //we search for first suitable

                    for (int i = 0; i < ready_processes_number; i++)
                    {
                        bool process_allocated = false;
                        for (int j = 0; j < mem_total_elements; j++)
                        {
                            if (Mem_Layout.ElementAt(j).Value.type == 'h')
                            {
                                if (Mem_Layout.ElementAt(j).Value.size >= Processes.First.Value.size)
                                {
                                    int new_key;

                                    Processes.First.Value.starting_address =
                                        Mem_Layout.ElementAt(j).Value.starting_address;

                                    Mem_Layout.ElementAt(j).Value.starting_address +=
                                        Processes.First.Value.size;
                                    new_key = Mem_Layout.ElementAt(j).Value.starting_address;

                                    Mem_Layout.ElementAt(j).Value.size -=
                                        Processes.First.Value.size;

                                    if (Mem_Layout.ElementAt(j).Value.size != 0)
                                    {
                                        Mem_Layout.Add(new_key, Mem_Layout.ElementAt(j).Value);
                                        Mem_Layout.RemoveAt(j);
                                        mem_total_elements++;
                                    }
                                    else
                                    {
                                        Mem_Layout.RemoveAt(j);
                                    }
                                    Memory_Element Process = new Memory_Element(
                                        Processes.First.Value.name, 'p',
                                        Processes.First.Value.size,
                                        Processes.First.Value.starting_address);
                                    Mem_Layout.Add(Process.starting_address, Process);
                                    //Processes.RemoveFirst();

                                    //ready_processes_number--;
                                    //i = -1;
                                    process_allocated = true;
                                    break;
                                }
                            }
                        }
                        if (process_allocated == false)
                        {
                            waiting_processes_number++;
                            Waiting_Processes.AddLast(Processes.First.Value);
                        }
                        Processes.RemoveFirst();
                        ready_processes_number--;
                        i = -1;
                    }

                }

                /** Memory Checkpoint 2 **/
                /*
                txtBox_pocesses_info.Text = "";
                for (int i = 0; i < ready_processes_number; i++)
                {
                    txtBox_pocesses_info.AppendText(
                        Processes.ElementAt(i).name + ", " +
                        Processes.ElementAt(i).starting_address.ToString() + ", " +
                        Processes.ElementAt(i).size.ToString() + ", " +
                        Processes.ElementAt(i).type.ToString() + "\n");

                }
                */

                else if (chk_best_fit.Checked) //Best Fit Algorithm
                {
                    //search for best partition(smallest) suitable for process
                    //we search for smallest suitable

                    for (int i = 0; i < ready_processes_number; i++)
                    {
                        int best_index = get_min_size_index(
                            Processes.First.Value.size, mem_total_elements,
                            Mem_Layout);

                        if (best_index > -1)
                        {
                            Processes.First.Value.starting_address =
                                Mem_Layout.ElementAt(best_index).Key;

                            Mem_Layout.ElementAt(best_index).Value.size -=
                                Processes.First.Value.size;

                            Mem_Layout.ElementAt(best_index).Value.starting_address +=
                                Processes.First.Value.size;
                            int new_key = Mem_Layout.ElementAt(best_index).Value.starting_address;

                            if (Mem_Layout.ElementAt(best_index).Value.size != 0)
                            {
                                Mem_Layout.Add(new_key, Mem_Layout.ElementAt(best_index).Value);
                                Mem_Layout.RemoveAt(best_index);
                                mem_total_elements++;
                            }
                            else
                            {
                                Mem_Layout.RemoveAt(best_index);
                            }
                            Memory_Element Process = new Memory_Element(
                                Processes.First.Value.name, 'p',
                                Processes.First.Value.size,
                                Processes.First.Value.starting_address);
                            Mem_Layout.Add(Process.starting_address, Process);

                        }
                        Processes.RemoveFirst();
                        i = -1;
                        ready_processes_number--;
                    }

                }
                else if (chk_worst_fit.Checked)
                {
                    for (int i = 0; i < ready_processes_number; i++)
                    {
                        int worst_index = get_max_size_index(
                            Processes.First.Value.size, mem_total_elements,
                            Mem_Layout);

                        if (worst_index > -1)
                        {
                            Processes.First.Value.starting_address =
                                Mem_Layout.ElementAt(worst_index).Key;

                            Mem_Layout.ElementAt(worst_index).Value.size -=
                                Processes.First.Value.size;

                            Mem_Layout.ElementAt(worst_index).Value.starting_address +=
                                Processes.First.Value.size;
                            int new_key = Mem_Layout.ElementAt(worst_index).Value.starting_address;

                            if (Mem_Layout.ElementAt(worst_index).Value.size != 0)
                            {
                                Mem_Layout.Add(new_key, Mem_Layout.ElementAt(worst_index).Value);
                                Mem_Layout.RemoveAt(worst_index);
                                mem_total_elements++;
                            }
                            else
                            {
                                Mem_Layout.RemoveAt(worst_index);
                            }
                            Memory_Element Process = new Memory_Element(
                                Processes.First.Value.name, 'p',
                                Processes.First.Value.size,
                                Processes.First.Value.starting_address);
                            Mem_Layout.Add(Process.starting_address, Process);

                        }
                        Processes.RemoveFirst();
                        i = -1;
                        ready_processes_number--;
                    }

                    //seach for the worst partition(greatest) suitable for process
                    //we search for greatest suitable
                }
                else if (chk_De_Allocate.Checked)
                {
                   // txtBox_pocesses_info.Text = ready_processes_number.ToString()
                     //   + "\n" + Processes.First.Value.name 
                       // + "\n" + Processes.Last.Value.name;

                    for (int i = 0; i < ready_processes_number; i++)
                    {
                        for (int j = 0; j < mem_total_elements; j++)
                        {
                            if (Mem_Layout.ElementAt(j).Value.type == 'p')
                            {
                                if (Processes.First.Value.name == Mem_Layout.ElementAt(j).Value.name)
                                {
                                    if (j == 0)
                                    {
                                        if (Mem_Layout.ElementAt(j + 1).Value.type == 'h')
                                        {
                                            Mem_Layout.ElementAt(j).Value.name = "hole";
                                            Mem_Layout.ElementAt(j).Value.type = 'h';
                                            Mem_Layout.ElementAt(j).Value.size +=
                                                Mem_Layout.ElementAt(j + 1).Value.size;

                                            Mem_Layout.RemoveAt(j + 1);
                                            mem_total_elements--;
                                        }
                                        else
                                        {
                                            Mem_Layout.ElementAt(j).Value.name = "hole";
                                            Mem_Layout.ElementAt(j).Value.type = 'h';
                                        }
                                    }
                                    else if (j == (mem_total_elements - 1))
                                    {
                                        if (Mem_Layout.ElementAt(j - 1).Value.type == 'h')
                                        {
                                            Mem_Layout.ElementAt(j - 1).Value.size +=
                                                Mem_Layout.ElementAt(j).Value.size;

                                            Mem_Layout.RemoveAt(j);
                                            mem_total_elements--;
                                        }
                                        else
                                        {
                                            Mem_Layout.ElementAt(j).Value.name = "hole";
                                            Mem_Layout.ElementAt(j).Value.type = 'h';
                                        }
                                    }
                                    else
                                    {
                                        if (Mem_Layout.ElementAt(j - 1).Value.type == 'h')
                                        {
                                            Mem_Layout.ElementAt(j - 1).Value.size +=
                                                Mem_Layout.ElementAt(j).Value.size;

                                            Mem_Layout.RemoveAt(j);
                                            mem_total_elements--;
                                        }
                                        else if (Mem_Layout.ElementAt(j + 1).Value.type == 'h')
                                        {
                                            Mem_Layout.ElementAt(j).Value.name = "hole";
                                            Mem_Layout.ElementAt(j).Value.type = 'h';
                                            Mem_Layout.ElementAt(j).Value.size +=
                                                Mem_Layout.ElementAt(j + 1).Value.size;

                                            Mem_Layout.RemoveAt(j + 1);
                                            mem_total_elements--;
                                        }
                                        else
                                        {
                                            Mem_Layout.ElementAt(j).Value.name = "hole";
                                            Mem_Layout.ElementAt(j).Value.type = 'h';
                                        }
                                    }

                                    break;
                                }
                            }
                        }
                        ready_processes_number--;
                        Processes.RemoveFirst();
                        i = -1;
                    }
                    //txtBox_pocesses_info.Text = ready_processes_number.ToString()
                    //    + "\n" + Mem_Layout.ElementAt(0).Value.name;
                }
                
                //txtBox_pocesses_info.Text = "Processes\nAllocated"+ "\n" +"View"+  "\n" + "Memory";
                /*
                for (int i = 0; i < mem_total_elements; i++)
                {
                    txtBox_pocesses_info.AppendText(
                        Mem_Layout.ElementAt(i).Value.name + ", " +
                        Mem_Layout.ElementAt(i).Value.starting_address.ToString() + ", " +
                        Mem_Layout.ElementAt(i).Value.size.ToString() + "\n");
                
                }
                */
            }
            //btn_Allocation.Enabled = false;
        }

        private void btn_show_memory_Click(object sender, EventArgs e)
        {
            if (btn_mem_update.Enabled == false)
            {
                txtBox_pocesses_info.Enabled = false;
                btn_Allocation.Enabled = false;
                btn_show_memory.Enabled = false;
                Memory Block = new Memory(mem_total_elements, Mem_Layout);
                Block.ShowDialog();
                back_to_allocation();
            }
        }

        private void chk_first_fit_CheckedChanged(object sender, EventArgs e)
        {
            chk_best_fit.Enabled = !chk_best_fit.Enabled;//false;
            chk_worst_fit.Enabled = !chk_worst_fit.Enabled;//false;
            chk_De_Allocate.Enabled = !chk_De_Allocate.Enabled;//false;
        }

        private void chk_best_fit_CheckedChanged(object sender, EventArgs e)
        {
            chk_first_fit.Enabled = !chk_first_fit.Enabled; //false;
            chk_worst_fit.Enabled = !chk_worst_fit.Enabled; //false;
            chk_De_Allocate.Enabled = !chk_De_Allocate.Enabled; //false;
        }

        private void chk_worst_fit_CheckedChanged(object sender, EventArgs e)
        {
            chk_first_fit.Enabled = !chk_first_fit.Enabled; //false;
            chk_best_fit.Enabled = !chk_best_fit.Enabled; //false;
            chk_De_Allocate.Enabled = !chk_De_Allocate.Enabled; //false;
        }

        private void chk_De_Allocate_CheckedChanged(object sender, EventArgs e)
        {
            chk_first_fit.Enabled = !chk_first_fit.Enabled; //false;
            chk_best_fit.Enabled = !chk_best_fit.Enabled; //false;
            chk_worst_fit.Enabled = !chk_worst_fit.Enabled; //false;
        }

        public void back_to_allocation()
        {
            btn_Allocation.Enabled = true;
            btn_show_memory.Enabled = true;
            txtBox_pocesses_info.Enabled = true;
            txtBox_pocesses_info.Text = "";
        }

        public int get_min_size_index(int ref_size, int list_size, SortedList<int, Memory_Element> List)
        {
            int min_size_index = -1;
            bool found_first_hole = false;
            for(int i = 0; i < list_size; i++)
            {
                if(List.ElementAt(i).Value.type == 'h')
                {
                    if(found_first_hole == false &&
                        ref_size <= List.ElementAt(i).Value.size)
                    {
                        found_first_hole = true;
                        min_size_index = i;
                    }
                    
                    if(found_first_hole == true)
                    {
                        if(List.ElementAt(i).Value.size < 
                            List.ElementAt(min_size_index).Value.size &&
                            ref_size <= List.ElementAt(i).Value.size)
                        {
                            min_size_index = i;
                        }
                    }
                }
            }
            
            return min_size_index;
        }

        public int get_max_size_index(int ref_size, int list_size, SortedList<int, Memory_Element> List)
        {
            int max_size_index = -1;
            bool found_first_hole = false;
            for (int i = 0; i < list_size; i++)
            {
                if (List.ElementAt(i).Value.type == 'h')
                {
                    if (found_first_hole == false &&
                        ref_size <= List.ElementAt(i).Value.size)
                    {
                        found_first_hole = true;
                        max_size_index = i;
                    }

                    if (found_first_hole == true)
                    {
                        if (List.ElementAt(i).Value.size >
                            List.ElementAt(max_size_index).Value.size &&
                            ref_size <= List.ElementAt(i).Value.size)
                        {
                            max_size_index = i;
                        }
                    }
                }
            }

            return max_size_index;
        }

    }

    public class Memory_Element
    {
        public string name;
        public char type;
        public int size, starting_address;
        public Memory_Element(int size, int starting_address)
        {
            this.size = size;
            this.starting_address = starting_address;
        }
        public Memory_Element(string name, char type, int size = 0, int starting_address = 0)
        {
            this.name = name;
            this.type = type;
            this.size = size;
            this.starting_address = starting_address;
        }
    }
}
