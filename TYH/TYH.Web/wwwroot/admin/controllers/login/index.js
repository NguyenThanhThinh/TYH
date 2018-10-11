var loginController = function() {
    this.initialize = function() {
        registerEvents();
    };

    var registerEvents = function() {
        $("#myform").validate({
            errorClass: "red",
            rules: {
                userName: { required: true, minlength: 6 },
                password: { required: true, minlength: 6 }

            },
            messages: {
                userName: { required: "Chưa nhập tài khoản", minlength: "Tối thiểu 6 kí tự" },
                password: { required: "Chưa nhập mật khẩu", minlength: "Tối thiểu 6 kí tự" }
            }
        });
        $("#btnLogin").on("click",
            function(e) {
                if ($("#myform").valid()) {
                    e.preventDefault();
                    const user = $("#txtUserName").val();
                    const password = $("#txtPassword").val();
                    login(user, password);
                }
            });
        $(document).keypress(function(e) {
            if (e.which === 13) {
                if ($("#myform").valid()) {
                    e.preventDefault();
                    const user = $("#txtUserName").val();
                    const password = $("#txtPassword").val();
                    login(user, password);
                }
            }
        });

    };

    var login = function(user, pass) {
        $.ajax({
            type: "POST",
            data: {
                UserName: user,
                Password: pass
            },
            dateType: "json",
            url: "/admin/login/authen",
            success: function(res) {
                if (res.Success) {
                    window.location.href = "/Admin/Home/Index";
                } else {
                    tyh.notify("Đăng nhập không đúng", "error");
                }
            }
        });
    };
}