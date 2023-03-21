<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.map = New GMap.NET.WindowsForms.GMapControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLat = New System.Windows.Forms.TextBox()
        Me.txtLong = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'map
        '
        Me.map.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.map.Bearing = 0!
        Me.map.CanDragMap = True
        Me.map.EmptyTileColor = System.Drawing.Color.Navy
        Me.map.GrayScaleMode = False
        Me.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.map.LevelsKeepInMemory = 5
        Me.map.Location = New System.Drawing.Point(11, 75)
        Me.map.Margin = New System.Windows.Forms.Padding(2)
        Me.map.MarkersEnabled = True
        Me.map.MaxZoom = 2
        Me.map.MinZoom = 2
        Me.map.MouseWheelZoomEnabled = True
        Me.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.map.Name = "map"
        Me.map.NegativeMode = False
        Me.map.PolygonsEnabled = True
        Me.map.RetryLoadTile = 0
        Me.map.RoutesEnabled = True
        Me.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.map.ShowTileGridLines = False
        Me.map.Size = New System.Drawing.Size(721, 384)
        Me.map.TabIndex = 0
        Me.map.Zoom = 0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Latitude"
        '
        'txtLat
        '
        Me.txtLat.Location = New System.Drawing.Point(73, 12)
        Me.txtLat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Size = New System.Drawing.Size(172, 20)
        Me.txtLat.TabIndex = 2
        '
        'txtLong
        '
        Me.txtLong.Location = New System.Drawing.Point(73, 35)
        Me.txtLong.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(172, 20)
        Me.txtLong.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Longitude"
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(254, 13)
        Me.btnGO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(114, 39)
        Me.btnGO.TabIndex = 5
        Me.btnGO.Text = "GO"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 457)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.txtLong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.map)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents map As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLat As TextBox
    Friend WithEvents txtLong As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGO As Button
    Friend WithEvents ImageList1 As ImageList
End Class
