namespace Cohesion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgInput = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCompare = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dgSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokensortratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokensetratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokeninitialismratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenabbrevratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightedratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSelected = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInput
            // 
            this.dgInput.AllowUserToAddRows = false;
            this.dgInput.AllowUserToResizeColumns = false;
            this.dgInput.AllowUserToResizeRows = false;
            this.dgInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.content,
            this.output});
            this.dgInput.Location = new System.Drawing.Point(12, 37);
            this.dgInput.Name = "dgInput";
            this.dgInput.ReadOnly = true;
            this.dgInput.RowHeadersVisible = false;
            this.dgInput.RowTemplate.Height = 25;
            this.dgInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInput.Size = new System.Drawing.Size(284, 703);
            this.dgInput.TabIndex = 0;
            this.dgInput.SelectionChanged += new System.EventHandler(this.dgInput_SelectionChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "Content";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // output
            // 
            this.output.HeaderText = "Output";
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Visible = false;
            // 
            // dgCompare
            // 
            this.dgCompare.AllowUserToAddRows = false;
            this.dgCompare.AllowUserToDeleteRows = false;
            this.dgCompare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCompare.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompare.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompare.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgCompare.Location = new System.Drawing.Point(1246, 37);
            this.dgCompare.MultiSelect = false;
            this.dgCompare.Name = "dgCompare";
            this.dgCompare.ReadOnly = true;
            this.dgCompare.RowHeadersVisible = false;
            this.dgCompare.RowTemplate.Height = 25;
            this.dgCompare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCompare.Size = new System.Drawing.Size(723, 703);
            this.dgCompare.TabIndex = 1;
            this.dgCompare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompare_CellContentClick);
            this.dgCompare.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCompare_CellFormatting);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 746);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(135, 39);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dgSelected
            // 
            this.dgSelected.AllowUserToAddRows = false;
            this.dgSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ratio,
            this.partialratio,
            this.tokensortratio,
            this.tokensetratio,
            this.tokeninitialismratio,
            this.tokenabbrevratio,
            this.weightedratio});
            this.dgSelected.Location = new System.Drawing.Point(302, 37);
            this.dgSelected.Name = "dgSelected";
            this.dgSelected.ReadOnly = true;
            this.dgSelected.RowHeadersVisible = false;
            this.dgSelected.RowTemplate.Height = 25;
            this.dgSelected.Size = new System.Drawing.Size(938, 703);
            this.dgSelected.TabIndex = 3;
            this.dgSelected.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSelected_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "content";
            this.dataGridViewTextBoxColumn2.HeaderText = "Content";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ratio
            // 
            this.ratio.HeaderText = "Ratio";
            this.ratio.Name = "ratio";
            this.ratio.ReadOnly = true;
            // 
            // partialratio
            // 
            this.partialratio.HeaderText = "Partial Ratio";
            this.partialratio.Name = "partialratio";
            this.partialratio.ReadOnly = true;
            // 
            // tokensortratio
            // 
            this.tokensortratio.HeaderText = "Token Sort Ratio";
            this.tokensortratio.Name = "tokensortratio";
            this.tokensortratio.ReadOnly = true;
            // 
            // tokensetratio
            // 
            this.tokensetratio.HeaderText = "Token Set Ratio";
            this.tokensetratio.Name = "tokensetratio";
            this.tokensetratio.ReadOnly = true;
            // 
            // tokeninitialismratio
            // 
            this.tokeninitialismratio.HeaderText = "Token Initialism Ratio";
            this.tokeninitialismratio.Name = "tokeninitialismratio";
            this.tokeninitialismratio.ReadOnly = true;
            // 
            // tokenabbrevratio
            // 
            this.tokenabbrevratio.HeaderText = "Token Abbrev Ratio";
            this.tokenabbrevratio.Name = "tokenabbrevratio";
            this.tokenabbrevratio.ReadOnly = true;
            // 
            // weightedratio
            // 
            this.weightedratio.HeaderText = "Weighted Ratio";
            this.weightedratio.Name = "weightedratio";
            this.weightedratio.ReadOnly = true;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelected.Location = new System.Drawing.Point(302, 12);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(130, 21);
            this.labelSelected.TabIndex = 4;
            this.labelSelected.Text = "Select an item...";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(153, 746);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(143, 39);
            this.buttonProcess.TabIndex = 5;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 792);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.dgSelected);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dgCompare);
            this.Controls.Add(this.dgInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgInput;
        private DataGridView dgCompare;
        private Button buttonLoad;
        private DataGridView dgSelected;
        private Label labelSelected;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ratio;
        private DataGridViewTextBoxColumn partialratio;
        private DataGridViewTextBoxColumn tokensortratio;
        private DataGridViewTextBoxColumn tokensetratio;
        private DataGridViewTextBoxColumn tokeninitialismratio;
        private DataGridViewTextBoxColumn tokenabbrevratio;
        private DataGridViewTextBoxColumn weightedratio;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn content;
        private DataGridViewTextBoxColumn output;
        private Button buttonProcess;
    }
}