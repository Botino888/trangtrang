
var SanPham = {
    init: function () {
        SanPham.registerEvents();
    },
    registerEvents: function () {
        $("#btn-Search").on('click',function (e) {
            console.log("trang");
            var id = $("#Search").val();
            console.log(id);
            $.ajax({
                url: "/SanPham/addRowSP",
                data: { MaSP: id },
                dataType: "json",
                type: "POST",
                success: function (result, status, xhr) {
                    $.each(result, function (key, item) {
                        console.log(item['MaDM']);
                        $("#Table-test tbody > tr").remove();
                        $("#Table-test > tbody").append("<tr>"
                            + "<td>" + item['MaSP'] + "</td >"
                            + "<td>" + item['TenSP'] + "</td >"
                            + "<td>" + item['GiaSP'] + "</td >"
                            + "<td>" + item['MaDM'] + "</td >"
                            + "<td>"+item['DanhMuc']+"</td>"
                            +"<td><a>Sửa</a></td>"
                            +"<td><a>Xóa</a></td>"
                            + "</tr>")
                    })
                    
                    
                    
                },
            });
        });
    },
}
SanPham.init();