$(window).scroll(function(event) {
    function footer()
    {
        var scroll = $(window).scrollTop();
        if(scroll > 25)
        {
            $(".footer-nav").fadeIn("slow").addClass("show");
        }
        else
        {
            $(".footer-nav").fadeOut("slow").removeClass("show");
        }

        clearTimeout($.data(this, 'scrollTimer'));
        $.data(this, 'scrollTimer', setTimeout(function() {
            if ($('.footer-nav').is(':hover')) {
                footer();
            }
            else
            {
                $(".footer-nav").fadeOut("slow");
            }
        }, 111110));
    }
    footer();
});
