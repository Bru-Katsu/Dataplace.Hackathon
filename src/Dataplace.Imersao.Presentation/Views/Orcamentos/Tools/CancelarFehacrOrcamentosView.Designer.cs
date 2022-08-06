namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class CancelarFehacrOrcamentosView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarFehacrOrcamentosView));
            this.gridOrcamento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDesmarca = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.rangeDate = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.optDataPrevFechamento = new System.Windows.Forms.RadioButton();
            this.optDataValidade = new System.Windows.Forms.RadioButton();
            this.optDataFechamento = new System.Windows.Forms.RadioButton();
            this.optDataAbertura = new System.Windows.Forms.RadioButton();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.optReabrir = new System.Windows.Forms.RadioButton();
            this.optFechar = new System.Windows.Forms.RadioButton();
            this.optCancelar = new System.Windows.Forms.RadioButton();
            this.lueCliente = new dpLibrary05.Infrastructure.Controls.DPLookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkComercializacao = new System.Windows.Forms.CheckBox();
            this.chkCondicaoPagto = new System.Windows.Forms.CheckBox();
            this.chkVendedores = new System.Windows.Forms.CheckBox();
            this.chkOrigemVenda = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lueTabelaPreco = new dpLibrary05.Infrastructure.Controls.DPLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrcamento.GroupByCaption = "Drag a column header here to group by that column";
            this.gridOrcamento.Images.Add(((System.Drawing.Image)(resources.GetObject("gridOrcamento.Images"))));
            this.gridOrcamento.Location = new System.Drawing.Point(3, 177);
            this.gridOrcamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridOrcamento.PreviewInfo.ZoomFactor = 75D;
            this.gridOrcamento.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.gridOrcamento.PrintInfo.MeasurementPrinterName = null;
            this.gridOrcamento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridOrcamento.PrintInfo.PageSettings")));
            this.gridOrcamento.Size = new System.Drawing.Size(1341, 422);
            this.gridOrcamento.TabIndex = 3;
            this.gridOrcamento.UseCompatibleTextRendering = false;
            this.gridOrcamento.PropBag = resources.GetString("gridOrcamento.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(1234, 143);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(109, 30);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Tag = "42291";
            this.btnCarregar.Text = "Consultar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 683);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(122, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMarcar,
            this.tsiDesmarca});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 24);
            this.toolStripSplitButton1.Tag = "5832";
            this.toolStripSplitButton1.Text = "Ferramentas";
            // 
            // tsiMarcar
            // 
            this.tsiMarcar.Name = "tsiMarcar";
            this.tsiMarcar.Size = new System.Drawing.Size(220, 26);
            this.tsiMarcar.Tag = "29709";
            this.tsiMarcar.Text = "Marcar Todos";
            // 
            // tsiDesmarca
            // 
            this.tsiDesmarca.Name = "tsiDesmarca";
            this.tsiDesmarca.Size = new System.Drawing.Size(220, 26);
            this.tsiDesmarca.Tag = "29708";
            this.tsiDesmarca.Text = "Desmarcar Todos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAberto);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkFechado);
            this.groupBox1.Location = new System.Drawing.Point(498, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "41797";
            this.groupBox1.Text = "Situação do orçamento";
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Checked = true;
            this.chkAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAberto.Location = new System.Drawing.Point(15, 31);
            this.chkAberto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(69, 20);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Tag = "3469";
            this.chkAberto.Text = "Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(191, 31);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(95, 20);
            this.chkCancelado.TabIndex = 2;
            this.chkCancelado.Tag = "3485";
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Location = new System.Drawing.Point(97, 31);
            this.chkFechado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(83, 20);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Tag = "3846";
            this.chkFechado.Text = "Fechado";
            this.chkFechado.UseVisualStyleBackColor = true;
            // 
            // rangeDate
            // 
            this.rangeDate.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rangeDate.DotNetContainer = false;
            this.rangeDate.KeyPreview = false;
            this.rangeDate.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.rangeDate.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.rangeDate.Location = new System.Drawing.Point(9, 18);
            this.rangeDate.Margin = new System.Windows.Forms.Padding(5);
            this.rangeDate.Name = "rangeDate";
            this.rangeDate.OpenModal = false;
            this.rangeDate.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("rangeDate.Parameters")));
            this.rangeDate.Size = new System.Drawing.Size(464, 27);
            this.rangeDate.TabIndex = 0;
            this.rangeDate.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.optDataPrevFechamento);
            this.gbData.Controls.Add(this.optDataValidade);
            this.gbData.Controls.Add(this.optDataFechamento);
            this.gbData.Controls.Add(this.optDataAbertura);
            this.gbData.Controls.Add(this.rangeDate);
            this.gbData.Location = new System.Drawing.Point(4, 4);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(487, 88);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Tag = "3159";
            this.gbData.Text = "Período";
            // 
            // optDataPrevFechamento
            // 
            this.optDataPrevFechamento.AutoSize = true;
            this.optDataPrevFechamento.Location = new System.Drawing.Point(226, 54);
            this.optDataPrevFechamento.Name = "optDataPrevFechamento";
            this.optDataPrevFechamento.Size = new System.Drawing.Size(137, 20);
            this.optDataPrevFechamento.TabIndex = 5;
            this.optDataPrevFechamento.TabStop = true;
            this.optDataPrevFechamento.Tag = "4845";
            this.optDataPrevFechamento.Text = "Prev. Fechamento";
            this.optDataPrevFechamento.UseVisualStyleBackColor = true;
            // 
            // optDataValidade
            // 
            this.optDataValidade.AutoSize = true;
            this.optDataValidade.Location = new System.Drawing.Point(382, 54);
            this.optDataValidade.Name = "optDataValidade";
            this.optDataValidade.Size = new System.Drawing.Size(83, 20);
            this.optDataValidade.TabIndex = 4;
            this.optDataValidade.TabStop = true;
            this.optDataValidade.Tag = "2979";
            this.optDataValidade.Text = "Validade";
            this.optDataValidade.UseVisualStyleBackColor = true;
            // 
            // optDataFechamento
            // 
            this.optDataFechamento.AutoSize = true;
            this.optDataFechamento.Location = new System.Drawing.Point(107, 54);
            this.optDataFechamento.Name = "optDataFechamento";
            this.optDataFechamento.Size = new System.Drawing.Size(103, 20);
            this.optDataFechamento.TabIndex = 3;
            this.optDataFechamento.TabStop = true;
            this.optDataFechamento.Tag = "3136";
            this.optDataFechamento.Text = "Fechamento";
            this.optDataFechamento.UseVisualStyleBackColor = true;
            // 
            // optDataAbertura
            // 
            this.optDataAbertura.AutoSize = true;
            this.optDataAbertura.Checked = true;
            this.optDataAbertura.Location = new System.Drawing.Point(15, 54);
            this.optDataAbertura.Name = "optDataAbertura";
            this.optDataAbertura.Size = new System.Drawing.Size(79, 20);
            this.optDataAbertura.TabIndex = 2;
            this.optDataAbertura.TabStop = true;
            this.optDataAbertura.Tag = "3142";
            this.optDataAbertura.Text = "Abertura";
            this.optDataAbertura.UseVisualStyleBackColor = true;
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.optReabrir);
            this.gbAcoes.Controls.Add(this.optFechar);
            this.gbAcoes.Controls.Add(this.optCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(4, 605);
            this.gbAcoes.Margin = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Padding = new System.Windows.Forms.Padding(4);
            this.gbAcoes.Size = new System.Drawing.Size(1339, 62);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Tag = "14912";
            this.gbAcoes.Text = "O que deseja fazer?";
            // 
            // optReabrir
            // 
            this.optReabrir.AutoSize = true;
            this.optReabrir.Location = new System.Drawing.Point(15, 30);
            this.optReabrir.Margin = new System.Windows.Forms.Padding(4);
            this.optReabrir.Name = "optReabrir";
            this.optReabrir.Size = new System.Drawing.Size(155, 20);
            this.optReabrir.TabIndex = 7;
            this.optReabrir.Tag = "";
            this.optReabrir.Text = "Reabrir orçamento(s)";
            this.optReabrir.UseVisualStyleBackColor = true;
            // 
            // optFechar
            // 
            this.optFechar.AutoSize = true;
            this.optFechar.Checked = true;
            this.optFechar.Location = new System.Drawing.Point(426, 30);
            this.optFechar.Margin = new System.Windows.Forms.Padding(4);
            this.optFechar.Name = "optFechar";
            this.optFechar.Size = new System.Drawing.Size(152, 20);
            this.optFechar.TabIndex = 0;
            this.optFechar.TabStop = true;
            this.optFechar.Tag = "";
            this.optFechar.Text = "Fechar orçamento(s)";
            this.optFechar.UseVisualStyleBackColor = true;
            // 
            // optCancelar
            // 
            this.optCancelar.AutoSize = true;
            this.optCancelar.Location = new System.Drawing.Point(214, 30);
            this.optCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.optCancelar.Name = "optCancelar";
            this.optCancelar.Size = new System.Drawing.Size(164, 20);
            this.optCancelar.TabIndex = 6;
            this.optCancelar.Tag = "";
            this.optCancelar.Text = "Cancelar orçamento(s)";
            this.optCancelar.UseVisualStyleBackColor = true;
            // 
            // lueCliente
            // 
            this.lueCliente.Active = false;
            this.lueCliente.ControlHandlesSearchExecution = true;
            this.lueCliente.DP_DataField = null;
            this.lueCliente.DP_FilterMemo = false;
            this.lueCliente.DP_SearchMethodFilter = null;
            this.lueCliente.DP_ShowCaption = true;
            this.lueCliente.FindMode = false;
            this.lueCliente.InterfaceField = null;
            this.lueCliente.IsReadonly = false;
            this.lueCliente.Location = new System.Drawing.Point(15, 26);
            this.lueCliente.Name = "lueCliente";
            this.lueCliente.SearchObject = null;
            this.lueCliente.SettingValue = false;
            this.lueCliente.Size = new System.Drawing.Size(458, 35);
            this.lueCliente.TabIndex = 501;
            this.lueCliente.Value = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lueCliente);
            this.groupBox2.Location = new System.Drawing.Point(4, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 81);
            this.groupBox2.TabIndex = 502;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "2791";
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkComercializacao);
            this.groupBox3.Controls.Add(this.chkCondicaoPagto);
            this.groupBox3.Controls.Add(this.chkVendedores);
            this.groupBox3.Controls.Add(this.chkOrigemVenda);
            this.groupBox3.Location = new System.Drawing.Point(921, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 168);
            this.groupBox3.TabIndex = 503;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "3632";
            this.groupBox3.Text = "Informações adicionais";
            // 
            // chkComercializacao
            // 
            this.chkComercializacao.AutoSize = true;
            this.chkComercializacao.Location = new System.Drawing.Point(16, 102);
            this.chkComercializacao.Name = "chkComercializacao";
            this.chkComercializacao.Size = new System.Drawing.Size(205, 20);
            this.chkComercializacao.TabIndex = 4;
            this.chkComercializacao.Text = "Selecionar Comercializações";
            this.chkComercializacao.UseVisualStyleBackColor = true;
            // 
            // chkCondicaoPagto
            // 
            this.chkCondicaoPagto.AutoSize = true;
            this.chkCondicaoPagto.Location = new System.Drawing.Point(16, 76);
            this.chkCondicaoPagto.Name = "chkCondicaoPagto";
            this.chkCondicaoPagto.Size = new System.Drawing.Size(254, 20);
            this.chkCondicaoPagto.TabIndex = 3;
            this.chkCondicaoPagto.Text = "Selecionar Condições de Pagamento";
            this.chkCondicaoPagto.UseVisualStyleBackColor = true;
            // 
            // chkVendedores
            // 
            this.chkVendedores.AutoSize = true;
            this.chkVendedores.Location = new System.Drawing.Point(16, 50);
            this.chkVendedores.Name = "chkVendedores";
            this.chkVendedores.Size = new System.Drawing.Size(172, 20);
            this.chkVendedores.TabIndex = 2;
            this.chkVendedores.Text = "Selecionar Vendedores";
            this.chkVendedores.UseVisualStyleBackColor = true;
            // 
            // chkOrigemVenda
            // 
            this.chkOrigemVenda.AutoSize = true;
            this.chkOrigemVenda.Location = new System.Drawing.Point(16, 24);
            this.chkOrigemVenda.Name = "chkOrigemVenda";
            this.chkOrigemVenda.Size = new System.Drawing.Size(206, 20);
            this.chkOrigemVenda.TabIndex = 1;
            this.chkOrigemVenda.Text = "Selecionar Origens de Venda";
            this.chkOrigemVenda.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lueTabelaPreco);
            this.groupBox4.Location = new System.Drawing.Point(498, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 81);
            this.groupBox4.TabIndex = 504;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "27393";
            this.groupBox4.Text = "Tabela de preço";
            // 
            // lueTabelaPreco
            // 
            this.lueTabelaPreco.Active = false;
            this.lueTabelaPreco.ControlHandlesSearchExecution = true;
            this.lueTabelaPreco.DP_DataField = null;
            this.lueTabelaPreco.DP_FilterMemo = false;
            this.lueTabelaPreco.DP_SearchMethodFilter = null;
            this.lueTabelaPreco.DP_ShowCaption = true;
            this.lueTabelaPreco.FindMode = false;
            this.lueTabelaPreco.InterfaceField = null;
            this.lueTabelaPreco.IsReadonly = false;
            this.lueTabelaPreco.Location = new System.Drawing.Point(12, 26);
            this.lueTabelaPreco.Name = "lueTabelaPreco";
            this.lueTabelaPreco.SearchObject = null;
            this.lueTabelaPreco.SettingValue = false;
            this.lueTabelaPreco.Size = new System.Drawing.Size(394, 35);
            this.lueTabelaPreco.TabIndex = 502;
            this.lueTabelaPreco.Value = null;
            // 
            // CancelarFehacrOrcamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gridOrcamento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelarFehacrOrcamentosView";
            this.Size = new System.Drawing.Size(1347, 750);
            this.Controls.SetChildIndex(this.gridOrcamento, 0);
            this.Controls.SetChildIndex(this.btnCarregar, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.gbAcoes, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkFechado;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.RadioButton optFechar;
        private System.Windows.Forms.RadioButton optCancelar;
        private System.Windows.Forms.RadioButton optReabrir;
        private dpLibrary05.Infrastructure.Controls.DPLookUpEdit lueCliente;
        private System.Windows.Forms.RadioButton optDataValidade;
        private System.Windows.Forms.RadioButton optDataFechamento;
        private System.Windows.Forms.RadioButton optDataAbertura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkOrigemVenda;
        private System.Windows.Forms.CheckBox chkVendedores;
        private System.Windows.Forms.RadioButton optDataPrevFechamento;
        private System.Windows.Forms.CheckBox chkComercializacao;
        private System.Windows.Forms.CheckBox chkCondicaoPagto;
        private System.Windows.Forms.GroupBox groupBox4;
        private dpLibrary05.Infrastructure.Controls.DPLookUpEdit lueTabelaPreco;
    }
}
