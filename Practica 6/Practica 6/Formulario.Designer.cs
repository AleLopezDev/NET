namespace Practica_6
{
    partial class FormularioHojaSaslarial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioHojaSaslarial));
            this.labelNif = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelHijos = new System.Windows.Forms.Label();
            this.labelTrienios = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cajaDni = new System.Windows.Forms.TextBox();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaHijos = new System.Windows.Forms.TextBox();
            this.cajaTrienios = new System.Windows.Forms.TextBox();
            this.cajaHorasExtras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.salarioBase = new System.Windows.Forms.Label();
            this.labelAntigüedad = new System.Windows.Forms.Label();
            this.labelHorasExtras = new System.Windows.Forms.Label();
            this.labelDevengos = new System.Windows.Forms.Label();
            this.labelPagaExtra = new System.Windows.Forms.Label();
            this.labelTotalDevengos = new System.Windows.Forms.Label();
            this.labelLiquido = new System.Windows.Forms.Label();
            this.labelSegSocial = new System.Windows.Forms.Label();
            this.labelSeguroDesempleo = new System.Windows.Forms.Label();
            this.labelIRPF = new System.Windows.Forms.Label();
            this.labelDescuentos = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxSBase = new System.Windows.Forms.TextBox();
            this.textBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.textBoxHExtras = new System.Windows.Forms.TextBox();
            this.textBoxPagasEx = new System.Windows.Forms.TextBox();
            this.textBoxSegSocial = new System.Windows.Forms.TextBox();
            this.textBoxSegDesempleo = new System.Windows.Forms.TextBox();
            this.textBoxIRPF = new System.Windows.Forms.TextBox();
            this.textBoxDeveng = new System.Windows.Forms.TextBox();
            this.textBoxDescuentos = new System.Windows.Forms.TextBox();
            this.textBoxLiquido = new System.Windows.Forms.TextBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Location = new System.Drawing.Point(30, 46);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(28, 16);
            this.labelNif.TabIndex = 1;
            this.labelNif.Text = "NIF";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(340, 52);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(30, 115);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(66, 16);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Categoría";
            this.labelCategoria.Click += new System.EventHandler(this.labelCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Periodo Liquidación (mm/aaaa)";
            // 
            // labelHijos
            // 
            this.labelHijos.AutoSize = true;
            this.labelHijos.Location = new System.Drawing.Point(234, 115);
            this.labelHijos.Name = "labelHijos";
            this.labelHijos.Size = new System.Drawing.Size(56, 16);
            this.labelHijos.TabIndex = 5;
            this.labelHijos.Text = "Nº Hijos";
            // 
            // labelTrienios
            // 
            this.labelTrienios.AutoSize = true;
            this.labelTrienios.Location = new System.Drawing.Point(428, 115);
            this.labelTrienios.Name = "labelTrienios";
            this.labelTrienios.Size = new System.Drawing.Size(74, 16);
            this.labelTrienios.TabIndex = 6;
            this.labelTrienios.Text = "Nº Trienios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nº Horas Extras";
            // 
            // cajaDni
            // 
            this.cajaDni.Location = new System.Drawing.Point(103, 43);
            this.cajaDni.Name = "cajaDni";
            this.cajaDni.Size = new System.Drawing.Size(100, 22);
            this.cajaDni.TabIndex = 8;
            this.cajaDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaDni_KeyPress);
            this.cajaDni.Leave += new System.EventHandler(this.cajaDni_Leave);
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(413, 46);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(336, 22);
            this.cajaNombre.TabIndex = 9;
            this.cajaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaNombre_KeyPress);
            this.cajaNombre.Leave += new System.EventHandler(this.cajaNombre_Leave);
            // 
            // cajaHijos
            // 
            this.cajaHijos.Location = new System.Drawing.Point(303, 115);
            this.cajaHijos.Name = "cajaHijos";
            this.cajaHijos.Size = new System.Drawing.Size(35, 22);
            this.cajaHijos.TabIndex = 11;
            this.cajaHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaHijos_KeyPress);
            this.cajaHijos.Leave += new System.EventHandler(this.cajaHijos_Leave);
            // 
            // cajaTrienios
            // 
            this.cajaTrienios.Location = new System.Drawing.Point(505, 115);
            this.cajaTrienios.Name = "cajaTrienios";
            this.cajaTrienios.Size = new System.Drawing.Size(35, 22);
            this.cajaTrienios.TabIndex = 12;
            this.cajaTrienios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaTrienios_KeyPress);
            this.cajaTrienios.Leave += new System.EventHandler(this.cajaTrienios_Leave);
            // 
            // cajaHorasExtras
            // 
            this.cajaHorasExtras.Location = new System.Drawing.Point(714, 115);
            this.cajaHorasExtras.Name = "cajaHorasExtras";
            this.cajaHorasExtras.Size = new System.Drawing.Size(35, 22);
            this.cajaHorasExtras.TabIndex = 13;
            this.cajaHorasExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaHorasExtras_KeyPress);
            this.cajaHorasExtras.Leave += new System.EventHandler(this.cajaHorasExtras_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Location = new System.Drawing.Point(543, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(206, 51);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboCategoria.Location = new System.Drawing.Point(103, 112);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(49, 24);
            this.comboCategoria.TabIndex = 16;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(237, 192);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(261, 22);
            this.dateTime.TabIndex = 17;
            // 
            // salarioBase
            // 
            this.salarioBase.AutoSize = true;
            this.salarioBase.Location = new System.Drawing.Point(36, 481);
            this.salarioBase.Name = "salarioBase";
            this.salarioBase.Size = new System.Drawing.Size(85, 16);
            this.salarioBase.TabIndex = 18;
            this.salarioBase.Text = "Salario Base";
            // 
            // labelAntigüedad
            // 
            this.labelAntigüedad.AutoSize = true;
            this.labelAntigüedad.Location = new System.Drawing.Point(36, 526);
            this.labelAntigüedad.Name = "labelAntigüedad";
            this.labelAntigüedad.Size = new System.Drawing.Size(76, 16);
            this.labelAntigüedad.TabIndex = 19;
            this.labelAntigüedad.Text = "Antigüedad";
            // 
            // labelHorasExtras
            // 
            this.labelHorasExtras.AutoSize = true;
            this.labelHorasExtras.Location = new System.Drawing.Point(36, 573);
            this.labelHorasExtras.Name = "labelHorasExtras";
            this.labelHorasExtras.Size = new System.Drawing.Size(84, 16);
            this.labelHorasExtras.TabIndex = 20;
            this.labelHorasExtras.Text = "Horas Extras";
            // 
            // labelDevengos
            // 
            this.labelDevengos.AutoSize = true;
            this.labelDevengos.ForeColor = System.Drawing.Color.Coral;
            this.labelDevengos.Location = new System.Drawing.Point(35, 432);
            this.labelDevengos.Name = "labelDevengos";
            this.labelDevengos.Size = new System.Drawing.Size(83, 16);
            this.labelDevengos.TabIndex = 21;
            this.labelDevengos.Text = "DEVENGOS";
            // 
            // labelPagaExtra
            // 
            this.labelPagaExtra.AutoSize = true;
            this.labelPagaExtra.Location = new System.Drawing.Point(35, 619);
            this.labelPagaExtra.Name = "labelPagaExtra";
            this.labelPagaExtra.Size = new System.Drawing.Size(80, 16);
            this.labelPagaExtra.TabIndex = 22;
            this.labelPagaExtra.Text = "Pagas Extra";
            // 
            // labelTotalDevengos
            // 
            this.labelTotalDevengos.AutoSize = true;
            this.labelTotalDevengos.Location = new System.Drawing.Point(35, 701);
            this.labelTotalDevengos.Name = "labelTotalDevengos";
            this.labelTotalDevengos.Size = new System.Drawing.Size(104, 16);
            this.labelTotalDevengos.TabIndex = 23;
            this.labelTotalDevengos.Text = "Total Devengos";
            // 
            // labelLiquido
            // 
            this.labelLiquido.AutoSize = true;
            this.labelLiquido.Location = new System.Drawing.Point(105, 793);
            this.labelLiquido.Name = "labelLiquido";
            this.labelLiquido.Size = new System.Drawing.Size(51, 16);
            this.labelLiquido.TabIndex = 24;
            this.labelLiquido.Text = "Líquido";
            // 
            // labelSegSocial
            // 
            this.labelSegSocial.AutoSize = true;
            this.labelSegSocial.Location = new System.Drawing.Point(404, 477);
            this.labelSegSocial.Name = "labelSegSocial";
            this.labelSegSocial.Size = new System.Drawing.Size(105, 16);
            this.labelSegSocial.TabIndex = 25;
            this.labelSegSocial.Text = "Cotiz.Seg Social";
            // 
            // labelSeguroDesempleo
            // 
            this.labelSeguroDesempleo.AutoSize = true;
            this.labelSeguroDesempleo.Location = new System.Drawing.Point(404, 526);
            this.labelSeguroDesempleo.Name = "labelSeguroDesempleo";
            this.labelSeguroDesempleo.Size = new System.Drawing.Size(141, 16);
            this.labelSeguroDesempleo.TabIndex = 26;
            this.labelSeguroDesempleo.Text = "Cotiz. Seg Desempleo";
            // 
            // labelIRPF
            // 
            this.labelIRPF.AutoSize = true;
            this.labelIRPF.Location = new System.Drawing.Point(404, 571);
            this.labelIRPF.Name = "labelIRPF";
            this.labelIRPF.Size = new System.Drawing.Size(101, 16);
            this.labelIRPF.TabIndex = 27;
            this.labelIRPF.Text = "Retención IRPF";
            // 
            // labelDescuentos
            // 
            this.labelDescuentos.AutoSize = true;
            this.labelDescuentos.Location = new System.Drawing.Point(404, 697);
            this.labelDescuentos.Name = "labelDescuentos";
            this.labelDescuentos.Size = new System.Drawing.Size(113, 16);
            this.labelDescuentos.TabIndex = 28;
            this.labelDescuentos.Text = "Total Descuentos";
            // 
            // buttonModificar
            // 
            this.buttonModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonModificar.Location = new System.Drawing.Point(407, 771);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(165, 55);
            this.buttonModificar.TabIndex = 29;
            this.buttonModificar.Text = "Modificar Datos";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonSalir.Location = new System.Drawing.Point(589, 771);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(165, 55);
            this.buttonSalir.TabIndex = 30;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxSBase
            // 
            this.textBoxSBase.Location = new System.Drawing.Point(178, 481);
            this.textBoxSBase.Name = "textBoxSBase";
            this.textBoxSBase.ReadOnly = true;
            this.textBoxSBase.Size = new System.Drawing.Size(100, 22);
            this.textBoxSBase.TabIndex = 32;
            // 
            // textBoxAntiguedad
            // 
            this.textBoxAntiguedad.Location = new System.Drawing.Point(178, 526);
            this.textBoxAntiguedad.Name = "textBoxAntiguedad";
            this.textBoxAntiguedad.ReadOnly = true;
            this.textBoxAntiguedad.Size = new System.Drawing.Size(100, 22);
            this.textBoxAntiguedad.TabIndex = 33;
            // 
            // textBoxHExtras
            // 
            this.textBoxHExtras.Location = new System.Drawing.Point(178, 573);
            this.textBoxHExtras.Name = "textBoxHExtras";
            this.textBoxHExtras.ReadOnly = true;
            this.textBoxHExtras.Size = new System.Drawing.Size(100, 22);
            this.textBoxHExtras.TabIndex = 34;
            // 
            // textBoxPagasEx
            // 
            this.textBoxPagasEx.Location = new System.Drawing.Point(178, 619);
            this.textBoxPagasEx.Name = "textBoxPagasEx";
            this.textBoxPagasEx.ReadOnly = true;
            this.textBoxPagasEx.Size = new System.Drawing.Size(100, 22);
            this.textBoxPagasEx.TabIndex = 35;
            // 
            // textBoxSegSocial
            // 
            this.textBoxSegSocial.Location = new System.Drawing.Point(612, 477);
            this.textBoxSegSocial.Name = "textBoxSegSocial";
            this.textBoxSegSocial.ReadOnly = true;
            this.textBoxSegSocial.Size = new System.Drawing.Size(100, 22);
            this.textBoxSegSocial.TabIndex = 36;
            // 
            // textBoxSegDesempleo
            // 
            this.textBoxSegDesempleo.Location = new System.Drawing.Point(612, 526);
            this.textBoxSegDesempleo.Name = "textBoxSegDesempleo";
            this.textBoxSegDesempleo.ReadOnly = true;
            this.textBoxSegDesempleo.Size = new System.Drawing.Size(100, 22);
            this.textBoxSegDesempleo.TabIndex = 37;
            // 
            // textBoxIRPF
            // 
            this.textBoxIRPF.Location = new System.Drawing.Point(612, 571);
            this.textBoxIRPF.Name = "textBoxIRPF";
            this.textBoxIRPF.ReadOnly = true;
            this.textBoxIRPF.Size = new System.Drawing.Size(100, 22);
            this.textBoxIRPF.TabIndex = 38;
            // 
            // textBoxDeveng
            // 
            this.textBoxDeveng.Location = new System.Drawing.Point(178, 701);
            this.textBoxDeveng.Name = "textBoxDeveng";
            this.textBoxDeveng.ReadOnly = true;
            this.textBoxDeveng.Size = new System.Drawing.Size(125, 22);
            this.textBoxDeveng.TabIndex = 39;
            // 
            // textBoxDescuentos
            // 
            this.textBoxDescuentos.Location = new System.Drawing.Point(617, 691);
            this.textBoxDescuentos.Name = "textBoxDescuentos";
            this.textBoxDescuentos.ReadOnly = true;
            this.textBoxDescuentos.Size = new System.Drawing.Size(137, 22);
            this.textBoxDescuentos.TabIndex = 40;
            // 
            // textBoxLiquido
            // 
            this.textBoxLiquido.Location = new System.Drawing.Point(178, 787);
            this.textBoxLiquido.Name = "textBoxLiquido";
            this.textBoxLiquido.ReadOnly = true;
            this.textBoxLiquido.Size = new System.Drawing.Size(125, 22);
            this.textBoxLiquido.TabIndex = 41;
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.ForeColor = System.Drawing.Color.Coral;
            this.labelDescuento.Location = new System.Drawing.Point(404, 428);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(101, 16);
            this.labelDescuento.TabIndex = 42;
            this.labelDescuento.Text = "DESCUENTOS";
            // 
            // FormularioHojaSaslarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 258);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.textBoxLiquido);
            this.Controls.Add(this.textBoxDescuentos);
            this.Controls.Add(this.textBoxDeveng);
            this.Controls.Add(this.textBoxIRPF);
            this.Controls.Add(this.textBoxSegDesempleo);
            this.Controls.Add(this.textBoxSegSocial);
            this.Controls.Add(this.textBoxPagasEx);
            this.Controls.Add(this.textBoxHExtras);
            this.Controls.Add(this.textBoxAntiguedad);
            this.Controls.Add(this.textBoxSBase);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelDescuentos);
            this.Controls.Add(this.labelIRPF);
            this.Controls.Add(this.labelSeguroDesempleo);
            this.Controls.Add(this.labelSegSocial);
            this.Controls.Add(this.labelLiquido);
            this.Controls.Add(this.labelTotalDevengos);
            this.Controls.Add(this.labelPagaExtra);
            this.Controls.Add(this.labelDevengos);
            this.Controls.Add(this.labelHorasExtras);
            this.Controls.Add(this.labelAntigüedad);
            this.Controls.Add(this.salarioBase);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cajaHorasExtras);
            this.Controls.Add(this.cajaTrienios);
            this.Controls.Add(this.cajaHijos);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.cajaDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTrienios);
            this.Controls.Add(this.labelHijos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioHojaSaslarial";
            this.Text = "Calculo Hoja Salarial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelHijos;
        private System.Windows.Forms.Label labelTrienios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cajaDni;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaHijos;
        private System.Windows.Forms.TextBox cajaTrienios;
        private System.Windows.Forms.TextBox cajaHorasExtras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label salarioBase;
        private System.Windows.Forms.Label labelAntigüedad;
        private System.Windows.Forms.Label labelHorasExtras;
        private System.Windows.Forms.Label labelDevengos;
        private System.Windows.Forms.Label labelPagaExtra;
        private System.Windows.Forms.Label labelTotalDevengos;
        private System.Windows.Forms.Label labelLiquido;
        private System.Windows.Forms.Label labelSegSocial;
        private System.Windows.Forms.Label labelSeguroDesempleo;
        private System.Windows.Forms.Label labelIRPF;
        private System.Windows.Forms.Label labelDescuentos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxSBase;
        private System.Windows.Forms.TextBox textBoxAntiguedad;
        private System.Windows.Forms.TextBox textBoxHExtras;
        private System.Windows.Forms.TextBox textBoxPagasEx;
        private System.Windows.Forms.TextBox textBoxSegSocial;
        private System.Windows.Forms.TextBox textBoxSegDesempleo;
        private System.Windows.Forms.TextBox textBoxIRPF;
        private System.Windows.Forms.TextBox textBoxDeveng;
        private System.Windows.Forms.TextBox textBoxDescuentos;
        private System.Windows.Forms.TextBox textBoxLiquido;
        private System.Windows.Forms.Label labelDescuento;
    }
}

