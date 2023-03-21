Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GMapControl1.MapProvider = BingMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        GMapControl1.MapProvider = BingHybridMapProvider.Instance
        GMapControl1.Position = New GMap.NET.PointLatLng(txtLat.Text.Trim(), txtLong.Text.Trim())
        GMapControl1.ShowCenter = False

        Dim markers As GMapOverlay = New GMapOverlay("markers")
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(txtLat.Text.Trim(), txtLong.Text.Trim()), GMarkerGoogleType.red)
        markers.Markers.Add(marker)
        GMapControl1.Overlays.Add(markers)

        GMapControl1.MinZoom = 5
        GMapControl1.MaxZoom = 100
        GMapControl1.Zoom = 14
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver




    End Sub

End Class