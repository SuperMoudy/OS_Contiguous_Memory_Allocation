namespace Assignment2_MemAllocation
{
    partial class Memory_Allocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_inputs = new System.Windows.Forms.TabControl();
            this.tab_holes_input = new System.Windows.Forms.TabPage();
            this.lbl_hole_input = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mem_update = new System.Windows.Forms.Button();
            this.lbl_hole_format = new System.Windows.Forms.Label();
            this.txtBox_holes_info = new System.Windows.Forms.TextBox();
            this.btn_size_number_cancel = new System.Windows.Forms.Button();
            this.btn_size_number_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_holes_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_memory_size = new System.Windows.Forms.TextBox();
            this.tab_processes_input = new System.Windows.Forms.TabPage();
            this.lbl_DeAllocation = new System.Windows.Forms.Label();
            this.lbl_process_format = new System.Windows.Forms.Label();
            this.lbl_process_input = new System.Windows.Forms.Label();
            this.btn_show_memory = new System.Windows.Forms.Button();
            this.btn_Allocation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_De_Allocate = new System.Windows.Forms.CheckBox();
            this.chk_worst_fit = new System.Windows.Forms.CheckBox();
            this.chk_best_fit = new System.Windows.Forms.CheckBox();
            this.chk_first_fit = new System.Windows.Forms.CheckBox();
            this.txtBox_pocesses_info = new System.Windows.Forms.TextBox();
            this.tab_inputs.SuspendLayout();
            this.tab_holes_input.SuspendLayout();
            this.tab_processes_input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_inputs
            // 
            this.tab_inputs.Controls.Add(this.tab_holes_input);
            this.tab_inputs.Controls.Add(this.tab_processes_input);
            this.tab_inputs.Location = new System.Drawing.Point(12, 12);
            this.tab_inputs.Name = "tab_inputs";
            this.tab_inputs.SelectedIndex = 0;
            this.tab_inputs.Size = new System.Drawing.Size(411, 279);
            this.tab_inputs.TabIndex = 0;
            // 
            // tab_holes_input
            // 
            this.tab_holes_input.Controls.Add(this.lbl_hole_input);
            this.tab_holes_input.Controls.Add(this.label4);
            this.tab_holes_input.Controls.Add(this.btn_mem_update);
            this.tab_holes_input.Controls.Add(this.lbl_hole_format);
            this.tab_holes_input.Controls.Add(this.txtBox_holes_info);
            this.tab_holes_input.Controls.Add(this.btn_size_number_cancel);
            this.tab_holes_input.Controls.Add(this.btn_size_number_ok);
            this.tab_holes_input.Controls.Add(this.label2);
            this.tab_holes_input.Controls.Add(this.txtBox_holes_number);
            this.tab_holes_input.Controls.Add(this.label1);
            this.tab_holes_input.Controls.Add(this.txtBox_memory_size);
            this.tab_holes_input.Location = new System.Drawing.Point(4, 22);
            this.tab_holes_input.Name = "tab_holes_input";
            this.tab_holes_input.Padding = new System.Windows.Forms.Padding(3);
            this.tab_holes_input.Size = new System.Drawing.Size(403, 253);
            this.tab_holes_input.TabIndex = 0;
            this.tab_holes_input.Text = "Holes Input";
            this.tab_holes_input.UseVisualStyleBackColor = true;
            // 
            // lbl_hole_input
            // 
            this.lbl_hole_input.AutoSize = true;
            this.lbl_hole_input.Location = new System.Drawing.Point(233, 143);
            this.lbl_hole_input.Name = "lbl_hole_input";
            this.lbl_hole_input.Size = new System.Drawing.Size(97, 13);
            this.lbl_hole_input.TabIndex = 10;
            this.lbl_hole_input.Text = "Hole Input Format: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "For each hole, enter its size and its starting address: ";
            // 
            // btn_mem_update
            // 
            this.btn_mem_update.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mem_update.Location = new System.Drawing.Point(236, 213);
            this.btn_mem_update.Name = "btn_mem_update";
            this.btn_mem_update.Size = new System.Drawing.Size(127, 34);
            this.btn_mem_update.TabIndex = 8;
            this.btn_mem_update.Text = "Update Memory";
            this.btn_mem_update.UseVisualStyleBackColor = true;
            this.btn_mem_update.Click += new System.EventHandler(this.btn_mem_update_Click);
            // 
            // lbl_hole_format
            // 
            this.lbl_hole_format.AutoSize = true;
            this.lbl_hole_format.Location = new System.Drawing.Point(233, 170);
            this.lbl_hole_format.Name = "lbl_hole_format";
            this.lbl_hole_format.Size = new System.Drawing.Size(151, 13);
            this.lbl_hole_format.TabIndex = 7;
            this.lbl_hole_format.Text = "hole size, hole starting address";
            // 
            // txtBox_holes_info
            // 
            this.txtBox_holes_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_holes_info.Location = new System.Drawing.Point(27, 122);
            this.txtBox_holes_info.Multiline = true;
            this.txtBox_holes_info.Name = "txtBox_holes_info";
            this.txtBox_holes_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_holes_info.Size = new System.Drawing.Size(189, 125);
            this.txtBox_holes_info.TabIndex = 6;
            this.txtBox_holes_info.Text = "10, 0\r\n40, 40\r\n100, 100\r\n50, 250";
            // 
            // btn_size_number_cancel
            // 
            this.btn_size_number_cancel.Location = new System.Drawing.Point(279, 59);
            this.btn_size_number_cancel.Name = "btn_size_number_cancel";
            this.btn_size_number_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_size_number_cancel.TabIndex = 5;
            this.btn_size_number_cancel.Text = "cancel";
            this.btn_size_number_cancel.UseVisualStyleBackColor = true;
            this.btn_size_number_cancel.Click += new System.EventHandler(this.btn_size_number_cancel_Click);
            // 
            // btn_size_number_ok
            // 
            this.btn_size_number_ok.Location = new System.Drawing.Point(279, 20);
            this.btn_size_number_ok.Name = "btn_size_number_ok";
            this.btn_size_number_ok.Size = new System.Drawing.Size(75, 22);
            this.btn_size_number_ok.TabIndex = 4;
            this.btn_size_number_ok.Text = "ok";
            this.btn_size_number_ok.UseVisualStyleBackColor = true;
            this.btn_size_number_ok.Click += new System.EventHandler(this.btn_size_number_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of holes";
            // 
            // txtBox_holes_number
            // 
            this.txtBox_holes_number.Location = new System.Drawing.Point(116, 62);
            this.txtBox_holes_number.Name = "txtBox_holes_number";
            this.txtBox_holes_number.Size = new System.Drawing.Size(100, 20);
            this.txtBox_holes_number.TabIndex = 2;
            this.txtBox_holes_number.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memory Size";
            // 
            // txtBox_memory_size
            // 
            this.txtBox_memory_size.Location = new System.Drawing.Point(116, 22);
            this.txtBox_memory_size.Name = "txtBox_memory_size";
            this.txtBox_memory_size.Size = new System.Drawing.Size(100, 20);
            this.txtBox_memory_size.TabIndex = 0;
            this.txtBox_memory_size.Text = "500";
            // 
            // tab_processes_input
            // 
            this.tab_processes_input.Controls.Add(this.lbl_DeAllocation);
            this.tab_processes_input.Controls.Add(this.lbl_process_format);
            this.tab_processes_input.Controls.Add(this.lbl_process_input);
            this.tab_processes_input.Controls.Add(this.btn_show_memory);
            this.tab_processes_input.Controls.Add(this.btn_Allocation);
            this.tab_processes_input.Controls.Add(this.groupBox1);
            this.tab_processes_input.Controls.Add(this.txtBox_pocesses_info);
            this.tab_processes_input.Location = new System.Drawing.Point(4, 22);
            this.tab_processes_input.Name = "tab_processes_input";
            this.tab_processes_input.Padding = new System.Windows.Forms.Padding(3);
            this.tab_processes_input.Size = new System.Drawing.Size(403, 253);
            this.tab_processes_input.TabIndex = 1;
            this.tab_processes_input.Text = "Processes Input";
            this.tab_processes_input.UseVisualStyleBackColor = true;
            // 
            // lbl_DeAllocation
            // 
            this.lbl_DeAllocation.AutoSize = true;
            this.lbl_DeAllocation.Location = new System.Drawing.Point(16, 46);
            this.lbl_DeAllocation.Name = "lbl_DeAllocation";
            this.lbl_DeAllocation.Size = new System.Drawing.Size(120, 13);
            this.lbl_DeAllocation.TabIndex = 10;
            this.lbl_DeAllocation.Text = "For De-Allocation: name";
            // 
            // lbl_process_format
            // 
            this.lbl_process_format.AutoSize = true;
            this.lbl_process_format.Location = new System.Drawing.Point(16, 27);
            this.lbl_process_format.Name = "lbl_process_format";
            this.lbl_process_format.Size = new System.Drawing.Size(124, 13);
            this.lbl_process_format.TabIndex = 9;
            this.lbl_process_format.Text = "For Allocation: name,size";
            // 
            // lbl_process_input
            // 
            this.lbl_process_input.AutoSize = true;
            this.lbl_process_input.Location = new System.Drawing.Point(13, 9);
            this.lbl_process_input.Name = "lbl_process_input";
            this.lbl_process_input.Size = new System.Drawing.Size(110, 13);
            this.lbl_process_input.TabIndex = 8;
            this.lbl_process_input.Text = "Process Input Format:";
            // 
            // btn_show_memory
            // 
            this.btn_show_memory.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_memory.Location = new System.Drawing.Point(219, 209);
            this.btn_show_memory.Name = "btn_show_memory";
            this.btn_show_memory.Size = new System.Drawing.Size(170, 34);
            this.btn_show_memory.TabIndex = 7;
            this.btn_show_memory.Text = "Show Memory";
            this.btn_show_memory.UseVisualStyleBackColor = true;
            this.btn_show_memory.Click += new System.EventHandler(this.btn_show_memory_Click);
            // 
            // btn_Allocation
            // 
            this.btn_Allocation.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Allocation.Location = new System.Drawing.Point(13, 209);
            this.btn_Allocation.Name = "btn_Allocation";
            this.btn_Allocation.Size = new System.Drawing.Size(173, 34);
            this.btn_Allocation.TabIndex = 6;
            this.btn_Allocation.Text = "Allocate / De-Allocate";
            this.btn_Allocation.UseVisualStyleBackColor = true;
            this.btn_Allocation.Click += new System.EventHandler(this.btn_Allocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_De_Allocate);
            this.groupBox1.Controls.Add(this.chk_worst_fit);
            this.groupBox1.Controls.Add(this.chk_best_fit);
            this.groupBox1.Controls.Add(this.chk_first_fit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allocation Algorithm";
            // 
            // chk_De_Allocate
            // 
            this.chk_De_Allocate.AutoSize = true;
            this.chk_De_Allocate.Location = new System.Drawing.Point(22, 146);
            this.chk_De_Allocate.Name = "chk_De_Allocate";
            this.chk_De_Allocate.Size = new System.Drawing.Size(108, 20);
            this.chk_De_Allocate.TabIndex = 3;
            this.chk_De_Allocate.Text = "De-Allocation";
            this.chk_De_Allocate.UseVisualStyleBackColor = true;
            this.chk_De_Allocate.CheckedChanged += new System.EventHandler(this.chk_De_Allocate_CheckedChanged);
            // 
            // chk_worst_fit
            // 
            this.chk_worst_fit.AutoSize = true;
            this.chk_worst_fit.Location = new System.Drawing.Point(22, 110);
            this.chk_worst_fit.Name = "chk_worst_fit";
            this.chk_worst_fit.Size = new System.Drawing.Size(79, 20);
            this.chk_worst_fit.TabIndex = 2;
            this.chk_worst_fit.Text = "Worst Fit";
            this.chk_worst_fit.UseVisualStyleBackColor = true;
            this.chk_worst_fit.CheckedChanged += new System.EventHandler(this.chk_worst_fit_CheckedChanged);
            // 
            // chk_best_fit
            // 
            this.chk_best_fit.AutoSize = true;
            this.chk_best_fit.Location = new System.Drawing.Point(22, 74);
            this.chk_best_fit.Name = "chk_best_fit";
            this.chk_best_fit.Size = new System.Drawing.Size(71, 20);
            this.chk_best_fit.TabIndex = 1;
            this.chk_best_fit.Text = "Best Fit";
            this.chk_best_fit.UseVisualStyleBackColor = true;
            this.chk_best_fit.CheckedChanged += new System.EventHandler(this.chk_best_fit_CheckedChanged);
            // 
            // chk_first_fit
            // 
            this.chk_first_fit.AutoSize = true;
            this.chk_first_fit.Location = new System.Drawing.Point(22, 37);
            this.chk_first_fit.Name = "chk_first_fit";
            this.chk_first_fit.Size = new System.Drawing.Size(69, 20);
            this.chk_first_fit.TabIndex = 0;
            this.chk_first_fit.Text = "First Fit";
            this.chk_first_fit.UseVisualStyleBackColor = true;
            this.chk_first_fit.CheckedChanged += new System.EventHandler(this.chk_first_fit_CheckedChanged);
            // 
            // txtBox_pocesses_info
            // 
            this.txtBox_pocesses_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pocesses_info.Location = new System.Drawing.Point(13, 66);
            this.txtBox_pocesses_info.Multiline = true;
            this.txtBox_pocesses_info.Name = "txtBox_pocesses_info";
            this.txtBox_pocesses_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox_pocesses_info.Size = new System.Drawing.Size(173, 126);
            this.txtBox_pocesses_info.TabIndex = 4;
            this.txtBox_pocesses_info.Text = "P1, 8\r\nP2, 30\r\nP3, 80\r\nP4, 40";
            // 
            // Memory_Allocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 303);
            this.Controls.Add(this.tab_inputs);
            this.Name = "Memory_Allocation";
            this.Text = "Memory_Allocation";
            this.tab_inputs.ResumeLayout(false);
            this.tab_holes_input.ResumeLayout(false);
            this.tab_holes_input.PerformLayout();
            this.tab_processes_input.ResumeLayout(false);
            this.tab_processes_input.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_inputs;
        private System.Windows.Forms.TabPage tab_holes_input;
        private System.Windows.Forms.Button btn_size_number_cancel;
        private System.Windows.Forms.Button btn_size_number_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_holes_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_memory_size;
        private System.Windows.Forms.TabPage tab_processes_input;
        public System.Windows.Forms.Button btn_show_memory;
        public System.Windows.Forms.Button btn_Allocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_De_Allocate;
        private System.Windows.Forms.CheckBox chk_worst_fit;
        private System.Windows.Forms.CheckBox chk_best_fit;
        private System.Windows.Forms.CheckBox chk_first_fit;
        private System.Windows.Forms.TextBox txtBox_pocesses_info;
        private System.Windows.Forms.Label lbl_hole_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_mem_update;
        private System.Windows.Forms.Label lbl_hole_format;
        private System.Windows.Forms.TextBox txtBox_holes_info;
        private System.Windows.Forms.Label lbl_process_format;
        private System.Windows.Forms.Label lbl_process_input;
        private System.Windows.Forms.Label lbl_DeAllocation;
    }
}

