namespace Ejercicio4
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
            btnGenerateMatrix = new Button();
            labelMatrix = new Label();
            inputRows = new TextBox();
            labelRows = new Label();
            labelCols = new Label();
            inputCols = new TextBox();
            errorLabel = new Label();
            btnReverse = new Button();
            btnSort = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnGenerateMatrix
            // 
            btnGenerateMatrix.Location = new Point(162, 246);
            btnGenerateMatrix.Name = "btnGenerateMatrix";
            btnGenerateMatrix.Size = new Size(115, 23);
            btnGenerateMatrix.TabIndex = 0;
            btnGenerateMatrix.Text = "Generar Matriz";
            btnGenerateMatrix.UseVisualStyleBackColor = true;
            btnGenerateMatrix.Click += button1_Click;
            // 
            // labelMatrix
            // 
            labelMatrix.AutoSize = true;
            labelMatrix.Location = new Point(489, 184);
            labelMatrix.Name = "labelMatrix";
            labelMatrix.Size = new Size(40, 15);
            labelMatrix.TabIndex = 1;
            labelMatrix.Text = "Matriz";
            labelMatrix.Click += labelMatrix_Click;
            // 
            // inputRows
            // 
            inputRows.Location = new Point(231, 144);
            inputRows.Name = "inputRows";
            inputRows.Size = new Size(55, 23);
            inputRows.TabIndex = 2;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(153, 144);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(30, 15);
            labelRows.TabIndex = 3;
            labelRows.Text = "Filas";
            // 
            // labelCols
            // 
            labelCols.AutoSize = true;
            labelCols.Location = new Point(153, 176);
            labelCols.Name = "labelCols";
            labelCols.Size = new Size(61, 15);
            labelCols.TabIndex = 4;
            labelCols.Text = "Columnas";
            // 
            // inputCols
            // 
            inputCols.Location = new Point(231, 176);
            inputCols.Name = "inputCols";
            inputCols.Size = new Size(55, 23);
            inputCols.TabIndex = 5;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(202, 215);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 6;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(220, 275);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(75, 23);
            btnReverse.TabIndex = 7;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(139, 275);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 8;
            btnSort.Text = "Ordenar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(179, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnSort);
            Controls.Add(btnReverse);
            Controls.Add(errorLabel);
            Controls.Add(inputCols);
            Controls.Add(labelCols);
            Controls.Add(labelRows);
            Controls.Add(inputRows);
            Controls.Add(labelMatrix);
            Controls.Add(btnGenerateMatrix);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateMatrix;
        private Label labelMatrix;
        private TextBox inputRows;
        private Label labelRows;
        private Label labelCols;
        private TextBox inputCols;
        private Label errorLabel;
        private Button btnReverse;
        private Button btnSort;
        private Button btnSave;
    }
}