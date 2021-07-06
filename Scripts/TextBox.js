$(document).ready(function () {
    $("#textBox1").on("click", function () {

        var inputJS = $("#textBox1").val();

        console.log(inputJS);

        //$("#message1").text("test" + this.id);

        $.ajax({
            url: "/Book/TextBox/" + inputJS,
            type: "POST"//,
            //data: { input: inputJS },
            //success: successFunc
        })

        function successFunc(data, status) {

            $("#textBox2").val(inputJS);
            alert(data);
        }
            
    });


    

});