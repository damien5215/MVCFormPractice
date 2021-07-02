$(document).ready(function () {
    $(".btnAdd").on("click", function () {

        $("#message1").text("test" + this.id);

        $.ajax({
            url: "/Book/AddToCart2/" + this.id,
            type: "GET"
            //data: { year: ((val * 1) + 1) }
        }).done(function () {

            $.ajax({
                url: "/Book/_Cart",
                type: "GET"
                //data: { year: ((val * 1) + 1) }
            }).done(function (partialViewResult) {
                $("#refTable").html(partialViewResult);
            });
        });
    });


    $(".btnDelete").on("click", function () {

        $.ajax({
            url: "/Book/RemoveFromCart/" + this.id,
            type: "GET"
        }).done(function () {

            $.ajax({
                url: "/Book/_Cart",
                type: "GET"
            })
                .done(function (partialViewResult) {
                    $("#refTable").html(partialViewResult);
                });
        });
    });

});