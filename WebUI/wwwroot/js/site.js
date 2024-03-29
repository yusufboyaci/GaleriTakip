﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    setTimeout(function () {
        $("div.loading").fadeOut("slow", function () {
            $("div.loading").hide();
        });
    }, 500);
});
function Gonder(lokasyon) {
    window.location.href = lokasyon;
};
//Bootsrapt table oluşturma metotu
function Veri_Listele(_url, id) {
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
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
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
            Swal.fire(
                'Veriler Eklendi!',
                'Verileriniz başarı ile eklenmiştir!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            }).then((result) => {
                if (result.isConfirmed) {
                }
            });
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
            Swal.fire(
                'Veriler Silindi!',
                'Veriler Başarıyla Silindi!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
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
            $('#GaleriAdGuncelle').val(result.ad);
            $('#GaleriAdresGuncelle').val(result.adres);
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
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
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Güncelleme yapılacak alan boş geldiği için Hata meydana geldi!',
        })
    }
    $.ajax({
        url: _url,
        method: 'PUT',
        data: _data,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            Swal.fire(
                'Veriler Güncellendi!',
                'Güncelleme işlemi başarıyla gerçekleşti!',
                'success'
            ).then((result) => {
                if (result.isConfirmed) {
                    window.location.reload();
                }
            });
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};
function Veri_Getir_ArabaIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            $('#ArabaAdGuncelle').val(result.ad);
            $('#ArabaUcretGuncelle').val(result.ucret);
            $('#ArabaStokGuncelle').val(result.stok);
            $('#ArabaBirimGuncelle').val(result.birim);
            $('#ArabaGaleriGuncelle').val(result.galeriId);
            $('#ArabaGaleriGuncelle option').val(result.galeriAdi);
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};
function ArabaTextBoxDoldur(id, ad, ucret, stok, birim, galeriId, galeriAdi) {
    this.id = id;
    this.ad = ad;
    this.ucret = ucret;
    this.stok = stok;
    this.birim = birim;
    this.galeriId = galeriId;
    this.galeriAdi = galeriAdi;
};
function GaleriListesi_Listele(_url, id_1, id_2) {
    var obj1 = $(`#${id_1}`);
    var obj2 = $(`#${id_2}`);
   obj1.empty();
   obj2.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj1.append(
                    `<option value="${result[i].id}">${result[i].ad}</option>`
                );
                obj2.append(
                    `<option value="${result[i].id}">${result[i].adres}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};
//Dosya yükleme için kullanılan metottur. https://www.findandsolve.com/articles/upload-file-using-ajax-in-asp-dot-net-core-dot-net-5 sitesinde anlatıyor
function uploadFile(_url, id, name) {
    var files = document.getElementById(id).files;
    if (files.length > 0) {
        if (window.FormData !== undefined) {
            var data = new FormData();
            for (var i = 0; i < files.length; i++) {
                data.append(name + i, files[i]);
            }
            $.ajax({
                method: 'POST',
                url: _url,
                contentType: false,
                processData: false,
                data: data,
                success: function (result) {
                    alert('Dosya Yüklendi');
                },
                error: function (err) {
                    console.log(err);
                    Swal.fire({
                        icon: 'error',
                        title: 'Hata...',
                        text: 'Sistem de Hata meydana geldi!',
                    });
                }
            });
        }
    }
};
function Veri_Getir_MusteriIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            $('#MusteriAdGuncelle').val(result.ad);
            $('#MusteriSoyadGuncelle').val(result.soyad);
            $('#KullaniciAdiGuncelle').val(result.kullaniciAdi);
            $('#PasswordGuncelle').val(result.password);
            $('#EmailGuncelle').val(result.email);
            $('#AdresGuncelle').val(result.adres);
            $('#TelefonNumarasiGuncelle').val(result.telefonNumarasi);
            $('#MusteriResimGuncelle').val(result.resim);
            $('#DogumGunuGuncelle').val(result.dogumGunu);
            $('#RoleGuncelle option').val(result.role);
        },
        error: function (err) {
            console.log(err);
            Swal.fire({
                icon: 'error',
                title: 'Hata...',
                text: 'Sistem de Hata meydana geldi!',
            });
        }
    });
};
function MusteriTextBoxDoldur(id, ad, soyad, kullaniciAdi, password, email, adres, telefonNumarasi, resim, dogumGunu, role) {
    this.id = id;
    this.ad = ad;
    this.soyad = soyad;
    this.kullaniciAdi = kullaniciAdi;
    this.password = password;
    this.email = email;
    this.adres = adres;
    this.telefonNumarasi = telefonNumarasi;
    this.resim = resim;
    this.dogumGunu = dogumGunu;
    this.role = role;
};
