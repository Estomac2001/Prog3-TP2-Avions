
namespace Generateur
{
    partial class GenerateurVue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateurVue));
            this.lstAero = new System.Windows.Forms.ListBox();
            this.txtNomAero = new System.Windows.Forms.TextBox();
            this.btnPosition = new System.Windows.Forms.Button();
            this.lblNomAero = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMinPassAero = new System.Windows.Forms.Label();
            this.lblMaxPassAero = new System.Windows.Forms.Label();
            this.lblMinMarchAero = new System.Windows.Forms.Label();
            this.lblMaxMarchAero = new System.Windows.Forms.Label();
            this.lblInfosAero = new System.Windows.Forms.Label();
            this.btnAjoutAero = new System.Windows.Forms.Button();
            this.lstVehi = new System.Windows.Forms.ListBox();
            this.lblInfosVehi = new System.Windows.Forms.Label();
            this.lblEntretient = new System.Windows.Forms.Label();
            this.lblDebarquement = new System.Windows.Forms.Label();
            this.lblEmbarquement = new System.Windows.Forms.Label();
            this.lblVitesse = new System.Windows.Forms.Label();
            this.lblNomVehi = new System.Windows.Forms.Label();
            this.txtNomVehi = new System.Windows.Forms.TextBox();
            this.lblTypeVehi = new System.Windows.Forms.Label();
            this.cmbTypeVehi = new System.Windows.Forms.ComboBox();
            this.btnAjoutAvion = new System.Windows.Forms.Button();
            this.btnAjoutScenario = new System.Windows.Forms.Button();
            this.numMinPassAero = new System.Windows.Forms.NumericUpDown();
            this.numMaxPassAero = new System.Windows.Forms.NumericUpDown();
            this.numMinMarchAero = new System.Windows.Forms.NumericUpDown();
            this.numMaxMarchAero = new System.Windows.Forms.NumericUpDown();
            this.numVitesse = new System.Windows.Forms.NumericUpDown();
            this.numEmbarquement = new System.Windows.Forms.NumericUpDown();
            this.numDebarquement = new System.Windows.Forms.NumericUpDown();
            this.numEntretient = new System.Windows.Forms.NumericUpDown();
            this.numMinMarchVehi = new System.Windows.Forms.NumericUpDown();
            this.numMinPassVehi = new System.Windows.Forms.NumericUpDown();
            this.lblMinMarchVehi = new System.Windows.Forms.Label();
            this.lblMinPassVehi = new System.Windows.Forms.Label();
            this.numMaxMarchVehi = new System.Windows.Forms.NumericUpDown();
            this.numMaxPassVehi = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMarchVehi = new System.Windows.Forms.Label();
            this.lblMaxPassVehi = new System.Windows.Forms.Label();
            this.lblInfosVehi2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPassAero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassAero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMarchAero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMarchAero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmbarquement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDebarquement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntretient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMarchVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPassVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMarchVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassVehi)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAero
            // 
            this.lstAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstAero.ForeColor = System.Drawing.Color.White;
            this.lstAero.FormattingEnabled = true;
            this.lstAero.Location = new System.Drawing.Point(15, 12);
            this.lstAero.Name = "lstAero";
            this.lstAero.Size = new System.Drawing.Size(1073, 121);
            this.lstAero.TabIndex = 0;
            // 
            // txtNomAero
            // 
            this.txtNomAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomAero.ForeColor = System.Drawing.Color.White;
            this.txtNomAero.Location = new System.Drawing.Point(53, 142);
            this.txtNomAero.Name = "txtNomAero";
            this.txtNomAero.Size = new System.Drawing.Size(100, 20);
            this.txtNomAero.TabIndex = 1;
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.Red;
            this.btnPosition.Location = new System.Drawing.Point(270, 142);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(75, 23);
            this.btnPosition.TabIndex = 7;
            this.btnPosition.Text = "Position";
            this.btnPosition.UseVisualStyleBackColor = false;
            // 
            // lblNomAero
            // 
            this.lblNomAero.AutoSize = true;
            this.lblNomAero.Location = new System.Drawing.Point(12, 147);
            this.lblNomAero.Name = "lblNomAero";
            this.lblNomAero.Size = new System.Drawing.Size(35, 13);
            this.lblNomAero.TabIndex = 8;
            this.lblNomAero.Text = "Nom: ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(171, 147);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(93, 13);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position (À choisir)";
            // 
            // lblMinPassAero
            // 
            this.lblMinPassAero.AutoSize = true;
            this.lblMinPassAero.Location = new System.Drawing.Point(353, 148);
            this.lblMinPassAero.Name = "lblMinPassAero";
            this.lblMinPassAero.Size = new System.Drawing.Size(102, 13);
            this.lblMinPassAero.TabIndex = 10;
            this.lblMinPassAero.Text = "Minimum passagers:";
            // 
            // lblMaxPassAero
            // 
            this.lblMaxPassAero.AutoSize = true;
            this.lblMaxPassAero.Location = new System.Drawing.Point(532, 147);
            this.lblMaxPassAero.Name = "lblMaxPassAero";
            this.lblMaxPassAero.Size = new System.Drawing.Size(105, 13);
            this.lblMaxPassAero.TabIndex = 11;
            this.lblMaxPassAero.Text = "Maximum passagers:";
            // 
            // lblMinMarchAero
            // 
            this.lblMinMarchAero.AutoSize = true;
            this.lblMinMarchAero.Location = new System.Drawing.Point(713, 146);
            this.lblMinMarchAero.Name = "lblMinMarchAero";
            this.lblMinMarchAero.Size = new System.Drawing.Size(119, 13);
            this.lblMinMarchAero.TabIndex = 12;
            this.lblMinMarchAero.Text = "Minimum marchandises:";
            // 
            // lblMaxMarchAero
            // 
            this.lblMaxMarchAero.AutoSize = true;
            this.lblMaxMarchAero.Location = new System.Drawing.Point(904, 147);
            this.lblMaxMarchAero.Name = "lblMaxMarchAero";
            this.lblMaxMarchAero.Size = new System.Drawing.Size(122, 13);
            this.lblMaxMarchAero.TabIndex = 13;
            this.lblMaxMarchAero.Text = "Maximum marchandises:";
            // 
            // lblInfosAero
            // 
            this.lblInfosAero.AutoSize = true;
            this.lblInfosAero.Location = new System.Drawing.Point(491, 165);
            this.lblInfosAero.Name = "lblInfosAero";
            this.lblInfosAero.Size = new System.Drawing.Size(484, 13);
            this.lblInfosAero.TabIndex = 15;
            this.lblInfosAero.Text = "Les minimums et maximums indique le nombre de groupes de passagers et de marchand" +
    "ises à l\'heure.";
            // 
            // btnAjoutAero
            // 
            this.btnAjoutAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjoutAero.Location = new System.Drawing.Point(15, 185);
            this.btnAjoutAero.Name = "btnAjoutAero";
            this.btnAjoutAero.Size = new System.Drawing.Size(1073, 20);
            this.btnAjoutAero.TabIndex = 16;
            this.btnAjoutAero.Text = "Ajouter l\'aéroport";
            this.btnAjoutAero.UseVisualStyleBackColor = false;
            this.btnAjoutAero.Click += new System.EventHandler(this.btnAjoutAero_Click);
            // 
            // lstVehi
            // 
            this.lstVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstVehi.ForeColor = System.Drawing.Color.White;
            this.lstVehi.FormattingEnabled = true;
            this.lstVehi.Location = new System.Drawing.Point(15, 223);
            this.lstVehi.Name = "lstVehi";
            this.lstVehi.Size = new System.Drawing.Size(1073, 121);
            this.lstVehi.TabIndex = 17;
            // 
            // lblInfosVehi
            // 
            this.lblInfosVehi.AutoSize = true;
            this.lblInfosVehi.Location = new System.Drawing.Point(308, 383);
            this.lblInfosVehi.Name = "lblInfosVehi";
            this.lblInfosVehi.Size = new System.Drawing.Size(288, 13);
            this.lblInfosVehi.TabIndex = 28;
            this.lblInfosVehi.Text = "C\'est le temps que prends l\'avion à faire l\'action (en heures).";
            // 
            // lblEntretient
            // 
            this.lblEntretient.AutoSize = true;
            this.lblEntretient.Location = new System.Drawing.Point(541, 361);
            this.lblEntretient.Name = "lblEntretient";
            this.lblEntretient.Size = new System.Drawing.Size(55, 13);
            this.lblEntretient.TabIndex = 27;
            this.lblEntretient.Text = "Entretient:";
            // 
            // lblDebarquement
            // 
            this.lblDebarquement.AutoSize = true;
            this.lblDebarquement.Location = new System.Drawing.Point(393, 361);
            this.lblDebarquement.Name = "lblDebarquement";
            this.lblDebarquement.Size = new System.Drawing.Size(80, 13);
            this.lblDebarquement.TabIndex = 26;
            this.lblDebarquement.Text = "Débarquement:";
            // 
            // lblEmbarquement
            // 
            this.lblEmbarquement.AutoSize = true;
            this.lblEmbarquement.Location = new System.Drawing.Point(244, 362);
            this.lblEmbarquement.Name = "lblEmbarquement";
            this.lblEmbarquement.Size = new System.Drawing.Size(81, 13);
            this.lblEmbarquement.TabIndex = 25;
            this.lblEmbarquement.Text = "Embarquement:";
            // 
            // lblVitesse
            // 
            this.lblVitesse.AutoSize = true;
            this.lblVitesse.Location = new System.Drawing.Point(13, 406);
            this.lblVitesse.Name = "lblVitesse";
            this.lblVitesse.Size = new System.Drawing.Size(44, 13);
            this.lblVitesse.TabIndex = 24;
            this.lblVitesse.Text = "Vitesse:";
            // 
            // lblNomVehi
            // 
            this.lblNomVehi.AutoSize = true;
            this.lblNomVehi.Location = new System.Drawing.Point(12, 353);
            this.lblNomVehi.Name = "lblNomVehi";
            this.lblNomVehi.Size = new System.Drawing.Size(35, 13);
            this.lblNomVehi.TabIndex = 23;
            this.lblNomVehi.Text = "Nom: ";
            // 
            // txtNomVehi
            // 
            this.txtNomVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomVehi.ForeColor = System.Drawing.Color.White;
            this.txtNomVehi.Location = new System.Drawing.Point(53, 348);
            this.txtNomVehi.Name = "txtNomVehi";
            this.txtNomVehi.Size = new System.Drawing.Size(139, 20);
            this.txtNomVehi.TabIndex = 18;
            // 
            // lblTypeVehi
            // 
            this.lblTypeVehi.AutoSize = true;
            this.lblTypeVehi.Location = new System.Drawing.Point(13, 377);
            this.lblTypeVehi.Name = "lblTypeVehi";
            this.lblTypeVehi.Size = new System.Drawing.Size(34, 13);
            this.lblTypeVehi.TabIndex = 29;
            this.lblTypeVehi.Text = "Type:";
            // 
            // cmbTypeVehi
            // 
            this.cmbTypeVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTypeVehi.ForeColor = System.Drawing.Color.White;
            this.cmbTypeVehi.FormattingEnabled = true;
            this.cmbTypeVehi.Location = new System.Drawing.Point(53, 373);
            this.cmbTypeVehi.Name = "cmbTypeVehi";
            this.cmbTypeVehi.Size = new System.Drawing.Size(139, 21);
            this.cmbTypeVehi.TabIndex = 30;
            // 
            // btnAjoutAvion
            // 
            this.btnAjoutAvion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjoutAvion.Location = new System.Drawing.Point(15, 436);
            this.btnAjoutAvion.Name = "btnAjoutAvion";
            this.btnAjoutAvion.Size = new System.Drawing.Size(1073, 23);
            this.btnAjoutAvion.TabIndex = 31;
            this.btnAjoutAvion.Text = "Ajouter l\'avion";
            this.btnAjoutAvion.UseVisualStyleBackColor = false;
            // 
            // btnAjoutScenario
            // 
            this.btnAjoutScenario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAjoutScenario.Location = new System.Drawing.Point(15, 479);
            this.btnAjoutScenario.Name = "btnAjoutScenario";
            this.btnAjoutScenario.Size = new System.Drawing.Size(1073, 36);
            this.btnAjoutScenario.TabIndex = 32;
            this.btnAjoutScenario.Text = "Exporter le scénario";
            this.btnAjoutScenario.UseVisualStyleBackColor = false;
            // 
            // numMinPassAero
            // 
            this.numMinPassAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinPassAero.ForeColor = System.Drawing.Color.White;
            this.numMinPassAero.Location = new System.Drawing.Point(461, 143);
            this.numMinPassAero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinPassAero.Name = "numMinPassAero";
            this.numMinPassAero.Size = new System.Drawing.Size(56, 20);
            this.numMinPassAero.TabIndex = 33;
            // 
            // numMaxPassAero
            // 
            this.numMaxPassAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaxPassAero.ForeColor = System.Drawing.Color.White;
            this.numMaxPassAero.Location = new System.Drawing.Point(643, 143);
            this.numMaxPassAero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxPassAero.Name = "numMaxPassAero";
            this.numMaxPassAero.Size = new System.Drawing.Size(56, 20);
            this.numMaxPassAero.TabIndex = 34;
            // 
            // numMinMarchAero
            // 
            this.numMinMarchAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinMarchAero.ForeColor = System.Drawing.Color.White;
            this.numMinMarchAero.Location = new System.Drawing.Point(838, 142);
            this.numMinMarchAero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinMarchAero.Name = "numMinMarchAero";
            this.numMinMarchAero.Size = new System.Drawing.Size(56, 20);
            this.numMinMarchAero.TabIndex = 35;
            // 
            // numMaxMarchAero
            // 
            this.numMaxMarchAero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaxMarchAero.ForeColor = System.Drawing.Color.White;
            this.numMaxMarchAero.Location = new System.Drawing.Point(1032, 142);
            this.numMaxMarchAero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxMarchAero.Name = "numMaxMarchAero";
            this.numMaxMarchAero.Size = new System.Drawing.Size(56, 20);
            this.numMaxMarchAero.TabIndex = 36;
            // 
            // numVitesse
            // 
            this.numVitesse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numVitesse.ForeColor = System.Drawing.Color.White;
            this.numVitesse.Location = new System.Drawing.Point(63, 403);
            this.numVitesse.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVitesse.Name = "numVitesse";
            this.numVitesse.Size = new System.Drawing.Size(65, 20);
            this.numVitesse.TabIndex = 37;
            // 
            // numEmbarquement
            // 
            this.numEmbarquement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEmbarquement.ForeColor = System.Drawing.Color.White;
            this.numEmbarquement.Location = new System.Drawing.Point(331, 358);
            this.numEmbarquement.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEmbarquement.Name = "numEmbarquement";
            this.numEmbarquement.Size = new System.Drawing.Size(56, 20);
            this.numEmbarquement.TabIndex = 38;
            // 
            // numDebarquement
            // 
            this.numDebarquement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDebarquement.ForeColor = System.Drawing.Color.White;
            this.numDebarquement.Location = new System.Drawing.Point(479, 358);
            this.numDebarquement.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDebarquement.Name = "numDebarquement";
            this.numDebarquement.Size = new System.Drawing.Size(56, 20);
            this.numDebarquement.TabIndex = 39;
            // 
            // numEntretient
            // 
            this.numEntretient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numEntretient.ForeColor = System.Drawing.Color.White;
            this.numEntretient.Location = new System.Drawing.Point(602, 358);
            this.numEntretient.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEntretient.Name = "numEntretient";
            this.numEntretient.Size = new System.Drawing.Size(56, 20);
            this.numEntretient.TabIndex = 40;
            // 
            // numMinMarchVehi
            // 
            this.numMinMarchVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinMarchVehi.ForeColor = System.Drawing.Color.White;
            this.numMinMarchVehi.Location = new System.Drawing.Point(1032, 348);
            this.numMinMarchVehi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinMarchVehi.Name = "numMinMarchVehi";
            this.numMinMarchVehi.Size = new System.Drawing.Size(56, 20);
            this.numMinMarchVehi.TabIndex = 44;
            // 
            // numMinPassVehi
            // 
            this.numMinPassVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMinPassVehi.ForeColor = System.Drawing.Color.White;
            this.numMinPassVehi.Location = new System.Drawing.Point(842, 347);
            this.numMinPassVehi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinPassVehi.Name = "numMinPassVehi";
            this.numMinPassVehi.Size = new System.Drawing.Size(56, 20);
            this.numMinPassVehi.TabIndex = 43;
            // 
            // lblMinMarchVehi
            // 
            this.lblMinMarchVehi.AutoSize = true;
            this.lblMinMarchVehi.Location = new System.Drawing.Point(904, 349);
            this.lblMinMarchVehi.Name = "lblMinMarchVehi";
            this.lblMinMarchVehi.Size = new System.Drawing.Size(119, 13);
            this.lblMinMarchVehi.TabIndex = 42;
            this.lblMinMarchVehi.Text = "Minimum marchandises:";
            // 
            // lblMinPassVehi
            // 
            this.lblMinPassVehi.AutoSize = true;
            this.lblMinPassVehi.Location = new System.Drawing.Point(731, 350);
            this.lblMinPassVehi.Name = "lblMinPassVehi";
            this.lblMinPassVehi.Size = new System.Drawing.Size(102, 13);
            this.lblMinPassVehi.TabIndex = 41;
            this.lblMinPassVehi.Text = "Minimum passagers:";
            // 
            // numMaxMarchVehi
            // 
            this.numMaxMarchVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaxMarchVehi.ForeColor = System.Drawing.Color.White;
            this.numMaxMarchVehi.Location = new System.Drawing.Point(1032, 376);
            this.numMaxMarchVehi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxMarchVehi.Name = "numMaxMarchVehi";
            this.numMaxMarchVehi.Size = new System.Drawing.Size(56, 20);
            this.numMaxMarchVehi.TabIndex = 48;
            // 
            // numMaxPassVehi
            // 
            this.numMaxPassVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numMaxPassVehi.ForeColor = System.Drawing.Color.White;
            this.numMaxPassVehi.Location = new System.Drawing.Point(842, 375);
            this.numMaxPassVehi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxPassVehi.Name = "numMaxPassVehi";
            this.numMaxPassVehi.Size = new System.Drawing.Size(56, 20);
            this.numMaxPassVehi.TabIndex = 47;
            // 
            // lblMaxMarchVehi
            // 
            this.lblMaxMarchVehi.AutoSize = true;
            this.lblMaxMarchVehi.Location = new System.Drawing.Point(904, 377);
            this.lblMaxMarchVehi.Name = "lblMaxMarchVehi";
            this.lblMaxMarchVehi.Size = new System.Drawing.Size(122, 13);
            this.lblMaxMarchVehi.TabIndex = 46;
            this.lblMaxMarchVehi.Text = "Maximum marchandises:";
            // 
            // lblMaxPassVehi
            // 
            this.lblMaxPassVehi.AutoSize = true;
            this.lblMaxPassVehi.Location = new System.Drawing.Point(731, 378);
            this.lblMaxPassVehi.Name = "lblMaxPassVehi";
            this.lblMaxPassVehi.Size = new System.Drawing.Size(105, 13);
            this.lblMaxPassVehi.TabIndex = 45;
            this.lblMaxPassVehi.Text = "Maximum passagers:";
            // 
            // lblInfosVehi2
            // 
            this.lblInfosVehi2.AutoSize = true;
            this.lblInfosVehi2.Location = new System.Drawing.Point(743, 399);
            this.lblInfosVehi2.Name = "lblInfosVehi2";
            this.lblInfosVehi2.Size = new System.Drawing.Size(336, 26);
            this.lblInfosVehi2.TabIndex = 49;
            this.lblInfosVehi2.Text = "       Les minimums et maximums indiquent le nombre de groupe de \r passagers et d" +
    "e marchandises qu\'un avion de transport peut prendre.";
            // 
            // GenerateurVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1103, 527);
            this.Controls.Add(this.lblInfosVehi2);
            this.Controls.Add(this.numMaxMarchVehi);
            this.Controls.Add(this.numMaxPassVehi);
            this.Controls.Add(this.lblMaxMarchVehi);
            this.Controls.Add(this.lblMaxPassVehi);
            this.Controls.Add(this.numMinMarchVehi);
            this.Controls.Add(this.numMinPassVehi);
            this.Controls.Add(this.lblMinMarchVehi);
            this.Controls.Add(this.lblMinPassVehi);
            this.Controls.Add(this.numEntretient);
            this.Controls.Add(this.numDebarquement);
            this.Controls.Add(this.numEmbarquement);
            this.Controls.Add(this.numVitesse);
            this.Controls.Add(this.numMaxMarchAero);
            this.Controls.Add(this.numMinMarchAero);
            this.Controls.Add(this.numMaxPassAero);
            this.Controls.Add(this.numMinPassAero);
            this.Controls.Add(this.btnAjoutScenario);
            this.Controls.Add(this.btnAjoutAvion);
            this.Controls.Add(this.cmbTypeVehi);
            this.Controls.Add(this.lblTypeVehi);
            this.Controls.Add(this.lblInfosVehi);
            this.Controls.Add(this.lblEntretient);
            this.Controls.Add(this.lblDebarquement);
            this.Controls.Add(this.lblEmbarquement);
            this.Controls.Add(this.lblVitesse);
            this.Controls.Add(this.lblNomVehi);
            this.Controls.Add(this.txtNomVehi);
            this.Controls.Add(this.lstVehi);
            this.Controls.Add(this.btnAjoutAero);
            this.Controls.Add(this.lblInfosAero);
            this.Controls.Add(this.lblMaxMarchAero);
            this.Controls.Add(this.lblMinMarchAero);
            this.Controls.Add(this.lblMaxPassAero);
            this.Controls.Add(this.lblMinPassAero);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNomAero);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.txtNomAero);
            this.Controls.Add(this.lstAero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateurVue";
            this.Text = "Générateur de scénarios";
            ((System.ComponentModel.ISupportInitialize)(this.numMinPassAero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassAero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMarchAero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMarchAero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEmbarquement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDebarquement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntretient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMarchVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPassVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMarchVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPassVehi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAero;
        private System.Windows.Forms.TextBox txtNomAero;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Label lblNomAero;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMinPassAero;
        private System.Windows.Forms.Label lblMaxPassAero;
        private System.Windows.Forms.Label lblMinMarchAero;
        private System.Windows.Forms.Label lblMaxMarchAero;
        private System.Windows.Forms.Label lblInfosAero;
        private System.Windows.Forms.Button btnAjoutAero;
        private System.Windows.Forms.ListBox lstVehi;
        private System.Windows.Forms.Label lblInfosVehi;
        private System.Windows.Forms.Label lblEntretient;
        private System.Windows.Forms.Label lblDebarquement;
        private System.Windows.Forms.Label lblEmbarquement;
        private System.Windows.Forms.Label lblVitesse;
        private System.Windows.Forms.Label lblNomVehi;
        private System.Windows.Forms.TextBox txtNomVehi;
        private System.Windows.Forms.Label lblTypeVehi;
        private System.Windows.Forms.ComboBox cmbTypeVehi;
        private System.Windows.Forms.Button btnAjoutAvion;
        private System.Windows.Forms.Button btnAjoutScenario;
        private System.Windows.Forms.NumericUpDown numMinPassAero;
        private System.Windows.Forms.NumericUpDown numMaxPassAero;
        private System.Windows.Forms.NumericUpDown numMinMarchAero;
        private System.Windows.Forms.NumericUpDown numMaxMarchAero;
        private System.Windows.Forms.NumericUpDown numVitesse;
        private System.Windows.Forms.NumericUpDown numEmbarquement;
        private System.Windows.Forms.NumericUpDown numDebarquement;
        private System.Windows.Forms.NumericUpDown numEntretient;
        private System.Windows.Forms.NumericUpDown numMinMarchVehi;
        private System.Windows.Forms.NumericUpDown numMinPassVehi;
        private System.Windows.Forms.Label lblMinMarchVehi;
        private System.Windows.Forms.Label lblMinPassVehi;
        private System.Windows.Forms.NumericUpDown numMaxMarchVehi;
        private System.Windows.Forms.NumericUpDown numMaxPassVehi;
        private System.Windows.Forms.Label lblMaxMarchVehi;
        private System.Windows.Forms.Label lblMaxPassVehi;
        private System.Windows.Forms.Label lblInfosVehi2;
    }
}