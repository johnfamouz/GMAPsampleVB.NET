Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.MapProviders
'Imports GMap.NET.WindowsPresentation
Imports System.Drawing.Imaging

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'map.DragButton = MouseButtons.Left
        'map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        'GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache
        'map.Position = New GMap.NET.PointLatLng(48.8589507, 2.2775175)
        'map.Zoom = 100

        'map.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance
        'map.MarkersEnabled = False

        map.MapProvider = GoogleMapProvider.Instance

        GMaps.Instance.Mode = AccessMode.ServerAndCache

        'map.MapProvider = GoogleHybridMapProvider.Instance
        map.MapProvider = GoogleSatelliteMapProvider.Instance
        map.Position = New GMap.NET.PointLatLng(10.149, 124.846414)
        'map.SetPositionByKeywords("Maasin City, Southern Leyte")
        map.ShowCenter = False


        Dim markers As GMapOverlay = New GMapOverlay("markers")
        'Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.1260000, 124.8780783), GMarkerGoogleType.red)
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.149, 124.846414), GMarkerGoogleType.red)
        markers.Markers.Add(marker)
        map.Overlays.Add(markers)


        map.MinZoom = 1
        map.MaxZoom = 22
        map.Zoom = 14
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver
        map.DragButton = MouseButtons.Left
        map.CanDragMap = True


    End Sub

    Private Sub btnSatellite_Click(sender As Object, e As EventArgs) Handles btnSatellite.Click
        '
        map.MapProvider = GoogleSatelliteMapProvider.Instance
        map.Position = New GMap.NET.PointLatLng(10.126, 124.8780783)
        'map.SetPositionByKeywords("Maasin City, Southern Leyte")
        map.ShowCenter = False
        Dim markers As GMapOverlay = New GMapOverlay("markers")
        'Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.13243, 124.840679), GMarkerGoogleType.red)
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.126, 124.8780783), GMarkerGoogleType.red)


        markers.Markers.Add(marker)
        map.Overlays.Add(markers)

        map.MinZoom = 5
        map.MaxZoom = 100
        map.Zoom = 20
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver


    End Sub

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click

        map.MapProvider = GoogleMapProvider.Instance
        map.Position = New GMap.NET.PointLatLng(10.126, 124.8780783)
        'map.SetPositionByKeywords("Maasin City, Southern Leyte")
        map.ShowCenter = False
        Dim markers As GMapOverlay = New GMapOverlay("markers")
        'Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.13243, 124.840679), GMarkerGoogleType.red)
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(10.126, 124.8780783), GMarkerGoogleType.red)


        markers.Markers.Add(marker)
        map.Overlays.Add(markers)

        map.MinZoom = 5
        map.MaxZoom = 100

        marker.ToolTipText = "\n 01350096 | ZABATE RICKETH JOHN"
        marker.ToolTip.Fill = Brushes.AliceBlue
        marker.ToolTip.Foreground = Brushes.Green
        marker.ToolTip.Stroke = Pens.Green
        marker.ToolTip.TextPadding = New Size(20, 20)
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver

    End Sub

    Private Sub map_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles map.OnMarkerClick
        MsgBox(item.Tag)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mapControl As New GMapControl()

        Using image As New Bitmap(mapControl.Width, mapControl.Height)
            mapControl.DrawToBitmap(image, New Rectangle(1000, 1000, image.Width, image.Height))
            image.Save("C:\Users\ADAADU\Documents\Visual Studio 2015\Projects\GMAPsample\GMAPsample\images\map.png", ImageFormat.Png)
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mapControl As New GMapControl()
        mapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance

        ' ... set up the mapControl with desired properties ...

        Dim startPoint As New PointLatLng(TextBox1.Text, TextBox2.Text)
        Dim endPoint As New PointLatLng(10.149, 124.846414)

        Dim route As GMapRoute = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(startPoint, endPoint, True, True, 14)
        Dim routeOverlay As New GMapOverlay("route")
        routeOverlay.Routes.Add(route)

        mapControl.Overlays.Add(routeOverlay)
    End Sub

    Private Sub map_OnMapDoubleClick(pointClick As PointLatLng, e As MouseEventArgs) Handles map.OnMapDoubleClick

        Dim point As PointLatLng = map.FromLocalToLatLng(e.X, e.Y)
        Dim lat As Double = point.Lat
        Dim lng As Double = point.Lng
        TextBox1.Text = lat
        TextBox2.Text = lng
    End Sub
End Class