<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NumLin = New System.Windows.Forms.NumericUpDown
        Me.DomLin = New System.Windows.Forms.DomainUpDown
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PicCm = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.DomCir = New System.Windows.Forms.DomainUpDown
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NumCir = New System.Windows.Forms.NumericUpDown
        Me.TimLin = New System.Windows.Forms.Timer(Me.components)
        Me.TimCir = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.NumLin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicCm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumLin
        '
        Me.NumLin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLin.Location = New System.Drawing.Point(6, 19)
        Me.NumLin.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.NumLin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumLin.Name = "NumLin"
        Me.NumLin.Size = New System.Drawing.Size(74, 23)
        Me.NumLin.TabIndex = 4
        Me.NumLin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumLin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DomLin
        '
        Me.DomLin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomLin.Items.Add("mm/s")
        Me.DomLin.Items.Add("mm/min")
        Me.DomLin.Items.Add("mm/h")
        Me.DomLin.Items.Add("cm/s")
        Me.DomLin.Items.Add("cm/min")
        Me.DomLin.Items.Add("cm/h")
        Me.DomLin.Items.Add("m/s")
        Me.DomLin.Items.Add("m/min")
        Me.DomLin.Items.Add("m/h")
        Me.DomLin.Items.Add("km/s")
        Me.DomLin.Items.Add("km/min")
        Me.DomLin.Items.Add("km/h")
        Me.DomLin.Location = New System.Drawing.Point(86, 19)
        Me.DomLin.Name = "DomLin"
        Me.DomLin.Size = New System.Drawing.Size(80, 23)
        Me.DomLin.TabIndex = 7
        Me.DomLin.Text = "mm/min"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DomLin)
        Me.GroupBox1.Controls.Add(Me.NumLin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(172, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 85)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Velocità lineare"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(92, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 33)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Stop"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(6, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 33)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Go !!!"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox2.Controls.Add(Me.PicCm)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 107)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Taratura pixel/cm"
        '
        'PicCm
        '
        Me.PicCm.Image = Global.SimulaVel.My.Resources.Resources.Cm
        Me.PicCm.Location = New System.Drawing.Point(6, 19)
        Me.PicCm.Name = "PicCm"
        Me.PicCm.Size = New System.Drawing.Size(85, 29)
        Me.PicCm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCm.TabIndex = 2
        Me.PicCm.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SimulaVel.My.Resources.Resources.Back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(6, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SimulaVel.My.Resources.Resources.Forward
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(49, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.DomCir)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.NumCir)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(350, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 148)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Velocità radiale"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "raggio (mm)"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(92, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 33)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Stop"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(6, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 33)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Go !!!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DomCir
        '
        Me.DomCir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomCir.Items.Add("giri/s")
        Me.DomCir.Items.Add("giri/min")
        Me.DomCir.Items.Add("giri/h")
        Me.DomCir.Location = New System.Drawing.Point(86, 19)
        Me.DomCir.Name = "DomCir"
        Me.DomCir.Size = New System.Drawing.Size(80, 23)
        Me.DomCir.TabIndex = 7
        Me.DomCir.Text = "giri/min"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 48)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(74, 23)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'NumCir
        '
        Me.NumCir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCir.Location = New System.Drawing.Point(6, 19)
        Me.NumCir.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.NumCir.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCir.Name = "NumCir"
        Me.NumCir.Size = New System.Drawing.Size(74, 23)
        Me.NumCir.TabIndex = 4
        Me.NumCir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumCir.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TimLin
        '
        Me.TimLin.Interval = 20
        '
        'TimCir
        '
        Me.TimCir.Interval = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SimulaVel.My.Resources.Resources.Red_Badge
        Me.PictureBox3.Location = New System.Drawing.Point(540, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SimulaVel.My.Resources.Resources.Car
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SimulaVel.My.Resources.Resources.Orizzon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(847, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SimulaVel.My.Resources.Resources.sfondo
        Me.ClientSize = New System.Drawing.Size(871, 309)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Simula velocità"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CType(Me.NumLin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicCm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicCm As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumLin As System.Windows.Forms.NumericUpDown
    Friend WithEvents DomLin As System.Windows.Forms.DomainUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DomCir As System.Windows.Forms.DomainUpDown
    Friend WithEvents NumCir As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TimLin As System.Windows.Forms.Timer
    Friend WithEvents TimCir As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown

End Class
