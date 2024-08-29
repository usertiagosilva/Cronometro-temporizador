
namespace CronometroTemporizador
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
            components = new System.ComponentModel.Container();
            Label label1;
            lblCronometro = new Label();
            lblTemporizador = new Label();
            btnPausar = new Button();
            btnParar = new Button();
            btnRedefinir = new Button();
            btnIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTempoInicial = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 295);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 7;
            label1.Text = "Digite o tempo inicial: ";
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(175, 40);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(94, 41);
            lblCronometro.TabIndex = 0;
            lblCronometro.Text = "00:00";
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemporizador.Location = new Point(175, 91);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(94, 41);
            lblTemporizador.TabIndex = 1;
            lblTemporizador.Text = "00:00";
            lblTemporizador.Click += lblTemporizador_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(30, 182);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(94, 29);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(175, 182);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(94, 29);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnRedefinir
            // 
            btnRedefinir.Location = new Point(315, 182);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(94, 29);
            btnRedefinir.TabIndex = 4;
            btnRedefinir.Text = "Redefinir";
            btnRedefinir.UseVisualStyleBackColor = true;
            btnRedefinir.Click += btnRedefinir_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(175, 241);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtTempoInicial
            // 
            txtTempoInicial.Location = new Point(166, 292);
            txtTempoInicial.Name = "txtTempoInicial";
            txtTempoInicial.Size = new Size(125, 27);
            txtTempoInicial.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 346);
            Controls.Add(label1);
            Controls.Add(txtTempoInicial);
            Controls.Add(btnIniciar);
            Controls.Add(btnRedefinir);
            Controls.Add(btnParar);
            Controls.Add(btnPausar);
            Controls.Add(lblTemporizador);
            Controls.Add(lblCronometro);
            Name = "Form1";
            Text = "Temporizador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTemporizador_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblCronometro;
        private Label lblTemporizador;
        private Button btnPausar;
        private Button btnParar;
        private Button btnRedefinir;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTempoInicial;
    }
}
