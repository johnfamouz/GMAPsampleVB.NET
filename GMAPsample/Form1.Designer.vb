<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.map = New GMap.NET.WindowsForms.GMapControl()
        Me.btnSatellite = New System.Windows.Forms.Button()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'map
        '
        Me.map.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.map.Bearing = 0!
        Me.map.CanDragMap = True
        Me.map.EmptyTileColor = System.Drawing.Color.SkyBlue
        Me.map.GrayScaleMode = False
        Me.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.map.LevelsKeepInMemory = 5
        Me.map.Location = New System.Drawing.Point(9, 31)
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
        Me.map.Size = New System.Drawing.Size(1307, 734)
        Me.map.TabIndex = 0
        Me.map.Zoom = 0R
        '
        'btnSatellite
        '
        Me.btnSatellite.Location = New System.Drawing.Point(9, 6)
        Me.btnSatellite.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSatellite.Name = "btnSatellite"
        Me.btnSatellite.Size = New System.Drawing.Size(168, 21)
        Me.btnSatellite.TabIndex = 1
        Me.btnSatellite.Text = "Satellite"
        Me.btnSatellite.UseVisualStyleBackColor = True
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(182, 6)
        Me.btnMap.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(168, 21)
        Me.btnMap.TabIndex = 2
        Me.btnMap.Text = "Map"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save MAP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Direction Plot"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(596, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(773, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 774)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(Me.btnSatellite)
        Me.Controls.Add(Me.map)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Consumer's Location"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents map As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents btnSatellite As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
