//Change the active class on the sidebar depending on the page...
$(document).ready(function () {
    
    $("a.navItem").hover(
         function () {
             $( ".Navitemtext" ).next().removeClass('hidden-sm');
             }, function() {
                 $( ".Navitemtext" ).next().addClass('hidden-sm');
             }
         });
});