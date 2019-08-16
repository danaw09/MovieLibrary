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
function updateMovieLibrary(){}
var data
   $.ajax({
       type: 'GET',
       url: "http://localhost:44398//api/movie",
       data: 'json',
       contentType: 'application/json',
       success: updateMovieLibrary (resp)
       (function( data, textStatus, jQxhr ){
        $('#response').html( data );
         
       }
   )
})