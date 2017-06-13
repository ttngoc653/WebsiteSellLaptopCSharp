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
$('#btnUpdate').on('click', function () {
    var pid = $(this).data('id');
    $('#id').val(pid);
    //alert(pid);
    var pqua = $('#inputQ_' + pid).val();
    //alert(pqua);
    $('#qua').val(pqua);
    $('#frmUpdate').submit();
});
