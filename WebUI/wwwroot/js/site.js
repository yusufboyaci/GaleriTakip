// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Gonder(lokasyon) {
    window.location.href = lokasyon;
};
function Galeri_Listele(_url, id) {
    var table = $(`#${id}`);
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (liste) {
            table.bootstrapTable('load', liste);
            table.bootstrapTable({ data: liste });
        },
        error: function (err) {
            alert('HATA');
            console.log(err);
        }
    })
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
function Veri_Sil(_url, veri) {
    var _data = JSON.stringify(veri);
    $.ajax({
        url: _url,
        method: 'DELETE',
        dataType: 'json',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            alert('Veriler Başarıyla Silindi.');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
