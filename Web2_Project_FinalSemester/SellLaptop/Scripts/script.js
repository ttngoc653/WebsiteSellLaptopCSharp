//validate birthday in register account
$(document).ready(function () {
    $('#ngsinh').datepicker({
        dateFormat: "dd/mm/yy",
        showStatus: true,
        showWeeks: true,
        currentText: 'Now',
        autoSize: true,
        gotoCurrent: true,
        showAnim: 'blind',
        autoClose: true,
        highlightWeek: true,
        endDate: '@DateTime.Now.Date'
    });
});

//form register account
/*$.ajax({
    url: this.action,
    type: this.method,
    data: $(this).serialize(),
    success: function (html) {
        alert("ĐÃ TẠO THÀNH CÔNG TÀI KHOẢN.");
    }
});*/

    
$('#btnRegister').click(function () {  
  
    // Checking whether FormData is available in browser  
    if (window.FormData !== undefined) {  
        var formData = new FormData();
        var totalFiles = document.getElementById("icon").files.length;
        for (var i = 0; i < totalFiles; i++) {
            var file = document.getElementById("icon").files[i];

            formData.append("icon", file);
        }
        $.ajax({
            type: this.Method,
            url: this.Action,
            data: formData,
            dataType: 'json',
            contentType: false,
            processData: false,
            success: function (response) {
                alert('succes!!');
            },
            error: function (error) {
                alert("errror");
            }
        });
    } else {  
        alert("FormData is not supported.");  
    }  
});

//update count product in cart
$('a[name="btnUpdate"]').on('click', function () {
    var pid = $(this).data('id');
    $('#id').val(pid);
    //alert(pid);
    var pqua = $('#inputQ_' + pid).val();
    //alert(pqua+' - '+pid);
    $('#qua').val(pqua);
    $('#frmUpdate').submit();
});


function testFile0() {
    document.getElementById("tbfile0").innerHTML = "";
    var x = document.getElementById("file0");
    var dayDinhDangAnh = ["image/jpeg", "image/jpg", "image/png", "image/gif", "image/tiff", "image/bmp"];
    if (x.files.length == 0) {
        document.getElementById("tbfile0").innerHTML = "hãy chọn tập tin";
        document.forms['themSanPham'].file0.focus();
        return false;
    }
    else {
        for (var i = 0; i < x.files.length; i++) {

            if (dayDinhDangAnh.indexOf(x.files[i].type) === -1) {
                document.getElementById("tbfile0").innerHTML = " không phải tập tin hình ảnh ";
                document.forms['themSanPham'].file0.focus();
                return false;
            }
        }
    }
    return true;
}
function testFile1() {
    document.getElementById("tbfile1").innerHTML = "";
    var x = document.getElementById("file1");
    var dayDinhDangAnh = ["image/jpeg", "image/jpg", "image/png", "image/gif", "image/tiff", "image/bmp"];
    if (x.files.length == 0) {
        document.getElementById("tbfile1").innerHTML = "hãy chọn tập tin";
        document.forms['themSanPham'].file1.focus();
        return false;
    }
    else {
        for (var i = 0; i < x.files.length; i++) {
            if (dayDinhDangAnh.indexOf(x.files[i].type) == -1) {
                document.getElementById("tbfile1").innerHTML = " không phải tập tin hình ảnh ";
                document.forms['themSanPham'].file1.focus();
                return false;
            }
        }
    }
    return true;
}
function testFile2() {

    document.getElementById("tbfile2").innerHTML = "";
    var x = document.getElementById("file2");
    var dayDinhDangAnh = ["image/jpeg", "image/jpg", "image/png", "image/gif", "image/tiff", "image/bmp"];
    if (x.files.length == 0) {
        document.getElementById("tbfile2").innerHTML = "hãy chọn tập tin";
        document.forms['themSanPham'].file2.focus();
        return false;
    }
    else {
        for (var i = 0; i < x.files.length; i++) {
            if (dayDinhDangAnh.indexOf(x.files[i].type) == -1) {
                document.getElementById("tbfile2").innerHTML = " không phải tập tin hình ảnh ";
                document.forms['themSanPham'].file2.focus();
                return false;
            }
        }
    }
    return true;
}
function testFile3() {
    document.getElementById("tbfile2").innerHTML = "";
    var x = document.getElementById("file3");
    var dayDinhDangAnh = ["image/jpeg", "image/jpg", "image/png", "image/gif", "image/tiff", "image/bmp"];
    if (x.files.length == 0) {
        document.getElementById("tbfile3").innerHTML = "hãy chọn tập tin";
        document.forms['themSanPham'].file3.focus();
        return false;
    }
    else {
        for (var i = 0; i < x.files.length; i++) {
            if (dayDinhDangAnh.indexOf(x.files[i].type) == -1) {
                document.getElementById("tbfile3").innerHTML = " không phải tập tin hình ảnh ";
                document.forms['themSanPham'].file3.focus();
                return false;
            }
        }
    }
    return true;
}
function testFile4() {
    document.getElementById("tbfile4").innerHTML = "";
    var x = document.getElementById("file4");
    var dayDinhDangAnh = ["image/jpeg", "image/jpg", "image/png", "image/gif", "image/tiff", "image/bmp"];
    if (x.files.length == 0) {
        document.getElementById("tbfile4").innerHTML = "hãy chọn tập tin";
        document.forms['themSanPham'].file4.focus();
        return false;
    }
    else {
        for (var i = 0; i < x.files.length; i++) {
            if (dayDinhDangAnh.indexOf(x.files[i].type) === -1) {
                document.getElementById("tbfile4").innerHTML = " không phải tập tin hình ảnh ";
                document.forms['themSanPham'].file4.focus();
                return false;
            }
        }
    }
    return true;
}
function ktradieukien() {
    var frm = window.document.themSanPham;
    var tam = "0";

    var thongbao = document.getElementById('thongbaoloi');
    thongbao.innerHTML = "LỖI: ";
    if (frm.ten.value === '') {
        thongbao.innerHTML += "Hãy nhập tên LAPTOP.";
        document.forms['themSanPham'].ten.focus();
        return false;
    }
    else if (frm.hangsx.value === "0") {
        thongbao.innerHTML += 'hãy chọn Hãng Sản xuất của máy.';
        document.forms['themSanPham'].hangsx.focus();
        return false;
    }
    else if ((frm.gia.value.length === 0) || (isNaN(frm.gia.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Giá của LAPTOP.';
        document.forms['themSanPham'].gia.focus();
        return false;
    }
    else if ((frm.mausac.value === '') || (isNaN(frm.mausac.value) === false)) {
        thongbao.innerHTML += 'hãy nhập lại Màu sắc của LAPTOP.';
        document.forms['themSanPham'].mausac.focus();
        return false;
    }
    else if (frm.cpu.value === 0) {
        thongbao.innerHTML += 'hãy chọn mã CPU của LAPTOP.';
        document.forms['themSanPham'].cpu.focus();
        return false;
    }
    else if ((frm.ramloai.value === "") || (isNaN(frm.ramloai.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Loại RAM hỗ trợ của LAPTOP.';
        document.forms['themSanPham'].ramloai.focus();
        return false;
    }
    else if ((frm.rambus.value === "") || (isNaN(frm.rambus.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại tốc độ bus trong ram của LAPTOP.';
        document.forms['themSanPham'].rambus.focus();
        return false;
    }
    else if ((frm.congngheat.value === "") || (isNaN(frm.congngheat.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại công nghệ âm thanh của LAPTOP.';
        document.forms['themSanPham'].congngheat.focus();
        return false;
    }
    else if ((frm.odia1.value === "") || (isNaN(frm.odia1.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Loại ổ đĩa hỗ trợ của LAPTOP.';
        document.forms['themSanPham'].odia1.focus();
        return false;
    }
    else if ((frm.odia1dl.value === "") || (isNaN(frm.odia1dl.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Dung lượng của ổ đĩa hổ trợ thứ 1 của LAPTOP.';
        document.forms['themSanPham'].odia1dl.focus();
        return false;
    }
    else if (frm.odia2.value.length > 0) {
        if (isNaN(frm.odia2.value) === false) {
            thongbao.innerHTML += 'hãy nhập lại Ổ đĩa hổ trợ thứ 2 của LAPTOP.';
            document.forms['themSanPham'].odia2.focus();
            return false;
        }
        else if ((frm.odia2dl.value === "") || (isNaN(frm.odia2dl.value) === true)) {
            thongbao.innerHTML += 'hãy nhập hoặc nhập lại Dung lượng của ổ đĩa hổ trợ thứ 2 của LAPTOP.';
            document.forms['themSanPham'].odia2dl.focus();
            return false;
        }
        else { }
    }
    else if ((frm.kichthuoc.value === "") || (isNaN(frm.kichthuoc.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Kích thước màn hình của LAPTOP.';
        document.forms['themSanPham'].kichthuoc.focus();
        return false;
    }
    else if ((frm.pgngang.value === "") || (isNaN(frm.pgngang.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại chiều ngang của độ phân giải của LAPTOP.';
        document.forms['themSanPham'].pgngang.focus();
        return false;
    }
    else if ((frm.pgdoc.value === "") || (isNaN(frm.pgdoc.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại chiều dọc của độ phân giải của LAPTOP.';
        document.forms['themSanPham'].pgdoc.focus();
        return false;
    }
    else if ((frm.oquang.value === "") || (isNaN(frm.oquang.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại loại Ổ CD/DVD của LAPTOP (không - không có ổ CD/DVD).';
        document.forms['themSanPham'].oquang.focus();
        return false;
    }
    else if ((frm.usb.value === "") || (isNaN(frm.usb.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại số cổng USB của LAPTOP.';
        document.forms['themSanPham'].usb.focus();
        return false;
    }
    else if ((frm.cother.value === "") || (isNaN(frm.cother.value) === false)) {
        thongbao.innerHTML += 'hãy nhập lại các cổng kết nối có hổ trợ khác của LAPTOP.';
        document.forms['themSanPham'].cother.focus();
        return false;
    }
    else if ((frm.wifi.value === "") || (isNaN(frm.wifi.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Chuẩn wifi (mạng không dây) của LAPTOP.';
        document.forms['themSanPham'].wifi.focus();
        return false;
    }
    else if ((frm.lan.value === "") || (isNaN(frm.lan.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Chuẩn LAN (mạng cáp) của LAPTOP.';
        document.forms['themSanPham'].lan.focus();
        return false;
    }
    else if ((frm.bluetooth.value === "") || (isNaN(frm.bluetooth.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại phiên bản BLUETOOTH hỗ trợ của LAPTOP.';
        document.forms['themSanPham'].bluetooth.focus();
        return false;
    }
    else if ((frm.camera.value === "") || (isNaN(frm.camera.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Độ phân giải Webcam camera của LAPTOP.';
        document.forms['themSanPham'].camera.focus();
        return false;
    }
    else if ((frm.hdh.value === "") || (isNaN(frm.hdh.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Hệ điều hành có sẵn của LAPTOP.';
        document.forms['themSanPham'].hdh.focus();
        return false;
    }
    else if ((frm.pin.value === "") || (isNaN(frm.pin.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Thông tin PIN của LAPTOP.';
        document.forms['themSanPham'].pin.focus();
        return false;
    }
    else if ((frm.nang.value === "") || (isNaN(frm.nang.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại Cân nặng của LAPTOP.';
        document.forms['themSanPham'].nang.focus();
        return false;
    }
    else if ((frm.dai.value === "") || (isNaN(frm.dai.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại CHIỀU DÀI của LAPTOP.';
        document.forms['themSanPham'].dai.focus();
        return false;
    }
    else if ((frm.rong.value === "") || (isNaN(frm.rong.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại CHIỀU RỘNG của LAPTOP.';
        document.forms['themSanPham'].rong.focus();
        return false;
    }
    else if ((frm.day.value === "") || (isNaN(frm.day.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại ĐỘ DÀY của LAPTOP.';
        document.forms['themSanPham'].day.focus();
        return false;
    }
    else if ((frm.chlieu.value === "") || (isNaN(frm.chlieu.value) === false)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại chất liệu của LAPTOP.';
        document.forms['themSanPham'].chlieu.focus();
        return false;
    }
    else if ((frm.slhienco.value === "") || (isNaN(frm.slhienco.value) === true)) {
        thongbao.innerHTML += 'hãy nhập hoặc nhập lại SỐ LƯỢNG LAPTOP HIỆN TẠI.';
        document.forms['themSanPham'].slhienco.focus();
        return false;
    }
    else {
        if (document.getElementById("file0").value.length == 0) {
            thongbao.innerHTML += 'chưa chọn file ảnh đại diện cho LAPTOP.';
            document.forms['themSanPham'].file0.focus();
            return false;
        }
        if (document.getElementById("file1").files.length == 0) {
            thongbao.innerHTML += 'chưa chọn file ảnh lớn cho LAPTOP.';
            document.forms['themSanPham'].file1.focus();
            return false;
        }
        if (document.getElementById("file2").files.length == 0) {
            thongbao.innerHTML += 'chưa chọn file ảnh thêm 1 cho LAPTOP.';
            document.forms['themSanPham'].file2.focus();
            return false;
        }
        if (document.getElementById("file3").files.length == 0) {
            thongbao.innerHTML += 'chưa chọn file ảnh thêm 2 cho LAPTOP.';
            document.forms['themSanPham'].file3.focus();
            return false;
        }
        if (document.getElementById("file4").files.length == 0) {
            thongbao.innerHTML += 'chưa chọn file ảnh thêm 3 cho LAPTOP.';
            document.forms['themSanPham'].file4.focus();
            return false;
        }
        thongbao.innerHTML += 'lalala true1';
        return true;
    }
    thongbao.innerHTML += 'lala true2';
    return true;
}