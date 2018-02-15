$(document).ready(function(){
    $("#score-display").hide();

    $("#scrabble-form").submit(function(event){
        event.preventDefault();

        var word = $("#scrabble-form input[name=scrabble-word]").val();
        $.ajax({
            url: "/score",
            type: "POST",
            data: {data: word},
            success: function(data)
            {
                $("#score-display").show();
                $("#score-display span[name=score-display]").text(data);
                $("#scrabble-form input[name=scrabble-word]").val("");
            },
            error: function(data){
                alert("An error occurred.");
            }
        });
    });
});
