$(document).ready(function () {
    $(".btnAdd").on("click", function () {

        $("#message1").text("test" + this.id);

        $.ajax({
            url: "/Book/AddToCart2/" + this.id,
            type: "GET"
        }).done(function () {

            $.ajax({
                url: "/Book/_Cart",
                type: "GET"
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

    $("#filterBooks").on("click", function () {

        var x1 = $("#genreList").val()
        //console.log("GenreID selected is " + x1);

        $.ajax({
            url: "/Book/_Books/" + x1,
            type: "POST"
        })
            .done(function (partialViewResult) {
                $("#bookTable").html(partialViewResult);
            });

    });

});