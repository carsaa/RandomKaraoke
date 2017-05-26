var sortOrder = 0;

function SortTable(n) {
    sortOrder = sortOrder == 0 ? 1 : 0;

    var table = document.getElementById("BStable");
    var rowData = table.getElementsByTagName('tr');

    var minIndex = 0;

    for (var i = 1; i < rowData.length - 1; i++) {
        var minIndex = i;

        for (var j = i + 1; j < rowData.length; j++) {

            if(sortOrder == 0)
            {
                if (rowData[minIndex].cells[n].innerHTML > rowData[j].cells[n].innerHTML) {
                    minIndex = j;
                }
            }
            else
            {
                if (rowData[minIndex].cells[n].innerHTML < rowData[j].cells[n].innerHTML) {
                    minIndex = j;
                }
            }
        }

        var temp = rowData[i].innerHTML;
        rowData[i].innerHTML = rowData[minIndex].innerHTML;
        rowData[minIndex].innerHTML = temp;
    }
}



function spotify() {
    var artist = $("#artist").val();
    var songtitle = $("#songtitle").val();
    var url = "https://api.spotify.com/v1/search?q=" + songtitle + "+" + artist + "&type=track&limit=1";
    console.log(url);
    if (artist && songtitle) {
        $.get(url).done(function (data) {
            console.log(data);
            var preview = data.tracks.items["0"].preview_url;
            var img = data.tracks.items["0"].album.images["0"].url

            $("#image").show();
            $("#audio").show();
            document.getElementById('audiofile').setAttribute('src', preview);
            document.getElementById('imgfile').setAttribute('src', img);

            //var audio = new Audio(preview);
            //audio.play();
            //document.getElementById('audiofile').setAttribute('type', 'normal');
            //$("#audiofile").src = preview;
            //$("#audiofile").play();
            //var url = "https://api.spotify.com/v1/search?q=" + artist + "&type=artist";
            //var audio = new Audio('https://p.scdn.co/mp3-preview/96038ec43852eb46dba2765bfa69199f478f84ea?cid=null');
        });
    }
});