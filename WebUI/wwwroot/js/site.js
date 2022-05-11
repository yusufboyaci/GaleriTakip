// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    setTimeout(function () {
        $("div.loading").fadeOut("slow", function () {
            $("div.loading").hide();
        });
    }, 500);
})
function Gonder(lokasyon) {
    window.location.href = lokasyon;
};
//Bootsrapt table oluşturma metotu
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
    });
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
    });
};
function Veri_Sil(_url, nesne) {
    var _data = JSON.stringify(nesne);
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
/*Güncelleme butonuna tıklanınca combobox lar dolu olsun diye yazıldı*/
function Veri_Getir_GaleriIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            console.log(result);
            $('#GaleriAdGuncelle').val(result.ad);
            $('#GaleriAdresGuncelle').val(result.adres);
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function GaleriTextBoxDoldur(id, ad, adres) {
    this.id = id;
    this.ad = ad;
    this.adres = adres;
};
function Veri_Guncelle(_url, nesne) {
    if (nesne != null) {
        var _data = JSON.stringify(nesne);
    }
    else {
        alert('Güncelleme yapılacak alan boş geldiği için Hata meydana geldi!');
    }
    $.ajax({
        url: _url,
        method: 'PUT',
        data: _data,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            alert('Güncelleme işlemi başarıyla gerçekleşti!');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
