
function addemp() {

    $(document).ready(function () {

        
        $("#btnCreate").click(function (e) {

            
            var data = $("form").serialize();

            if (!$("form").valid()) {
                e.preventDefault();
                return false;
            }

            alertify.alert("Successfully Saved.", function () {

                $.ajax({
                    type: "POST",
                    url: "/Home/Create",
                    data: data,
                    success: function (respose) {
                        window.location.href = "/Home/Index";

                    }

                });
            });
        });

    });
}

$(function () {
    addemp();
});

$("#btnCancel").click(function () {
    window.location.href = "/Home/Index";
    //return false;
});


function Delete(id) {

    alertify.confirm("Are you sure do you want to delete this?", function (e) {
        if (e) {
            $.ajax({
                type: "POST",
                url: "/Home/Delete",
                data: { id: id },
                success: function (response) {
                    window.location.href = "/Home/Index";
                }
            });
        } else
        {
            window.location.href = "/Home/Index";
        }
    });
   
}



