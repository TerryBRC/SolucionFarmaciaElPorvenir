namespace FarmaciaElPorvenir
{
    partial class Inventario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSeekMedicamento = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStock2 = new DevExpress.XtraEditors.TextEdit();
            this.txtStock3 = new DevExpress.XtraEditors.TextEdit();
            this.txtStock4 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeekMedicamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnNuevo);
            this.layoutControl1.Controls.Add(this.txtStock);
            this.layoutControl1.Controls.Add(this.btnActualizar);
            this.layoutControl1.Controls.Add(this.txtSeekMedicamento);
            this.layoutControl1.Controls.Add(this.txtStock2);
            this.layoutControl1.Controls.Add(this.txtStock3);
            this.layoutControl1.Controls.Add(this.txtStock4);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(841, 45, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(896, 543);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Location = new System.Drawing.Point(12, 30);
            this.gridControl1.MainView = this.gridViewRoles;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(872, 193);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRoles});
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(FarmaciaElPorvenir.el_porvenirdb.Inventario);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // gridViewRoles
            // 
            this.gridViewRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.colStock,
            this.colPrecio_Compra,
            this.colPrecio_Venta,
            this.colFecha_Vencimiento});
            this.gridViewRoles.CustomizationFormBounds = new System.Drawing.Rectangle(957, 338, 259, 272);
            this.gridViewRoles.GridControl = this.gridControl1;
            this.gridViewRoles.Name = "gridViewRoles";
            this.gridViewRoles.OptionsBehavior.Editable = false;
            this.gridViewRoles.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRoles.OptionsView.RowAutoHeight = true;
            this.gridViewRoles.OptionsView.ShowDetailButtons = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Id_Medicamento!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Medicamento";
            this.gridColumn2.FieldName = "Id_Medicamento.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 1;
            // 
            // colPrecio_Compra
            // 
            this.colPrecio_Compra.FieldName = "Precio_Compra";
            this.colPrecio_Compra.Name = "colPrecio_Compra";
            this.colPrecio_Compra.Visible = true;
            this.colPrecio_Compra.VisibleIndex = 2;
            // 
            // colPrecio_Venta
            // 
            this.colPrecio_Venta.FieldName = "Precio_Venta";
            this.colPrecio_Venta.Name = "colPrecio_Venta";
            this.colPrecio_Venta.Visible = true;
            this.colPrecio_Venta.VisibleIndex = 3;
            // 
            // colFecha_Vencimiento
            // 
            this.colFecha_Vencimiento.FieldName = "Fecha_Vencimiento";
            this.colFecha_Vencimiento.Name = "colFecha_Vencimiento";
            this.colFecha_Vencimiento.Visible = true;
            this.colFecha_Vencimiento.VisibleIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(12, 478);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(872, 53);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(450, 420);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(434, 53);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(12, 420);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(434, 53);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(12, 363);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(434, 53);
            this.btnNuevo.StyleController = this.layoutControl1;
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(156, 261);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtStock.Properties.Appearance.Options.UseFont = true;
            this.txtStock.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtStock.Properties.UseMaskAsDisplayFormat = true;
            this.txtStock.Size = new System.Drawing.Size(728, 30);
            this.txtStock.StyleController = this.layoutControl1;
            this.txtStock.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(450, 363);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(434, 53);
            this.btnActualizar.StyleController = this.layoutControl1;
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            // 
            // txtSeekMedicamento
            // 
            this.txtSeekMedicamento.Location = new System.Drawing.Point(156, 227);
            this.txtSeekMedicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeekMedicamento.Name = "txtSeekMedicamento";
            this.txtSeekMedicamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtSeekMedicamento.Properties.Appearance.Options.UseFont = true;
            this.txtSeekMedicamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSeekMedicamento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id_Medicamento.Nombre", "Id_Medicamento.Nombre", 129, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtSeekMedicamento.Properties.DataSource = this.xpCollection1;
            this.txtSeekMedicamento.Properties.DisplayMember = "Id_Medicamento.Nombre";
            this.txtSeekMedicamento.Properties.KeyMember = "Id_Medicamento.Nombre";
            this.txtSeekMedicamento.Properties.NullText = "";
            this.txtSeekMedicamento.Size = new System.Drawing.Size(728, 30);
            this.txtSeekMedicamento.StyleController = this.layoutControl1;
            this.txtSeekMedicamento.TabIndex = 2;
            // 
            // txtStock2
            // 
            this.txtStock2.Location = new System.Drawing.Point(156, 295);
            this.txtStock2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock2.Name = "txtStock2";
            this.txtStock2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtStock2.Properties.Appearance.Options.UseFont = true;
            this.txtStock2.Size = new System.Drawing.Size(728, 30);
            this.txtStock2.StyleController = this.layoutControl1;
            this.txtStock2.TabIndex = 2;
            // 
            // txtStock3
            // 
            this.txtStock3.Location = new System.Drawing.Point(156, 329);
            this.txtStock3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock3.Name = "txtStock3";
            this.txtStock3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtStock3.Properties.Appearance.Options.UseFont = true;
            this.txtStock3.Size = new System.Drawing.Size(728, 30);
            this.txtStock3.StyleController = this.layoutControl1;
            this.txtStock3.TabIndex = 2;
            // 
            // txtStock4
            // 
            this.txtStock4.Location = new System.Drawing.Point(184, 329);
            this.txtStock4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock4.Name = "txtStock4";
            this.txtStock4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtStock4.Properties.Appearance.Options.UseFont = true;
            this.txtStock4.Size = new System.Drawing.Size(700, 30);
            this.txtStock4.StyleController = this.layoutControl1;
            this.txtStock4.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(896, 543);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(876, 17);
            this.simpleLabelItem1.Text = "Inventario";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(132, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 17);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(876, 1);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 465);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(876, 1);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancelar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 466);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(876, 57);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.txtStock;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 249);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(876, 34);
            this.layoutControlItem8.Text = "Stock:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(132, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 18);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(876, 197);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnGuardar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(438, 57);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnNuevo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 351);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(438, 57);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnActualizar;
            this.layoutControlItem6.Location = new System.Drawing.Point(438, 351);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(438, 57);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEliminar;
            this.layoutControlItem2.Location = new System.Drawing.Point(438, 408);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(438, 57);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtSeekMedicamento;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "Stock:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 215);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(876, 34);
            this.layoutControlItem7.Text = "Medicamento:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(132, 19);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtStock2;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "Stock:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 283);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(876, 34);
            this.layoutControlItem9.Text = "Precio de Compra:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(132, 19);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.Control = this.txtStock3;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "Stock:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 317);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(876, 34);
            this.layoutControlItem10.Text = "Precio de Venta:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(132, 19);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 543);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeekMedicamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRoles;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Compra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Vencimiento;
        private DevExpress.XtraEditors.LookUpEdit txtSeekMedicamento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit txtStock2;
        private DevExpress.XtraEditors.TextEdit txtStock3;
        private DevExpress.XtraEditors.TextEdit txtStock4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}
