(function($){
    function processForm( e ){
        var dict = {
        	Title : this["title"].value,
            Director: this["director"],
            Genre : this["genre"].value,
           
        };

        $.ajax({
            url: 'https://localhost:44398//api/movie',
            dataType: 'json',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(dict),
            success: function( data, textStatus, jQxhr ){
                $('#response').html( data );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });

        e.preventDefault();
    }

    $('#my-form').submit( processForm );
})(jQuery); 