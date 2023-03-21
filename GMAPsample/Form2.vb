Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.MapProviders

Public Class Form2
    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click

        map.MapProvider = GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        map.MapProvider = GoogleHybridMapProvider.Instance
        map.Position = New GMap.NET.PointLatLng(txtLat.Text.Trim(), txtLong.Text.Trim())
        map.ShowCenter = False

        Dim markers As GMapOverlay = New GMapOverlay("markers")
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(txtLat.Text.Trim(), txtLong.Text.Trim()), GMarkerGoogleType.red)
        markers.Markers.Add(marker)
        map.Overlays.Add(markers)

        map.MinZoom = 5
        map.MaxZoom = 100
        map.Zoom = 20
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver

    End Sub

End Class


