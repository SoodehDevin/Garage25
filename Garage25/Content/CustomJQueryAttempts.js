//jquery file for Index view

//$(document).ready(function () {
//    $('.col-md-4').on('mouseenter', function () {
//        // $(this).css({'background-color': '#ffcce6'});
//        $(this).addClass('highlight');
//        //alert('working');
//    });
//});

$(document).ready(function () {
    $('.row').on('mouseenter', '.col-md-4', function () {
        // $(this).css({'background-color': '#ffcce6'});
        $(this).addClass('highlight');
        //alert('working');
    });
    $('.row').on('mouseleave', '.col-md-4', function () {
        $(this).removeClass('highlight');
    });
});