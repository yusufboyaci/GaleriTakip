// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Gonder(lokasyon) {
    window.location.href = lokasyon;
};
function Tablo_Olustur(id) {
    $('#' + id).DataTable();
};
function Veri_Ekle(_url, id, _data = null) {
    var frm = $('#' + id);
    if (_data == null) {
        _data = JSON.stringify(frm.serializeJSON());
    }
    $.ajax({
        url: _url,
        method: 'POST',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            alert('Ekleme yapıldı');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    })
};
function Veri_Listele(_url, id) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (liste) {
            for (var i = 0; i < liste.length; i++) {
                $('#' + id).append(`<tr><td> ${liste[i].ad}</td></tr> 
                                    <tr><td> ${liste[i].adres}</td></tr>`)
            }
        },
        error: function (err) {
            alert('HATA');
            console.log(err);
        }
    })
}