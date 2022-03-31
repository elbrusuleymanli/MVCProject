(function ($) {
"use strict";  
    
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    
    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
    $(".notice-left").niceScroll({
        cursorcolor: "#EC1C23",
        cursorborder: "0px solid #fff",
        autohidemode: false,
    });

    //subscribe

    $('#subsc').on('click', function (e) {
        e.preventDefault();
       
        let email = $(".email").val();


       

        $.ajax({
            url: "/contact/addSubscribe/",
            type: "post",
            dataType: "Json",

            data: { email: email },
            success: function (response) {

                if (response == 200) {
                    $(".email").val("")
                    alert("email is added")

                }
                else if (response == 500) {
                    alert("is not email")
                }
                else {
                    alert("email elave olunmadi")
                }

            }
        })
    })

    //reply

    $('#reply').on('click', function (e) {
        e.preventDefault();
        console.log("click")
        let email = $(".email").val();
        let name = $(".name").val();
        let subject = $(".subject").val();
        let text = $(".text").val();
        $.ajax({
            url: "/course/SendMessage/",
            type: "post",
            dataType: "Json",

            data: { email: email, name: name, subject: subject, text: text },

            success: function (response) {

                if (response == 200) {
                    $(".email").val(""),
                        $(".name").val(""),
                        $(".subject").val(""),
                        $(".text").val("")
                    alert("Message sent")

                }
                else if (response == 500) {
                    alert("Incorrect data")
                }
                else {
                    alert("email elave olunmadi")
                }

            }
        })




    })
   
    /*-----------------------
        Search Toggle
    ------------------------- */
    let searchSelector = document.querySelector('.search-toggle');
    let searchBox = document.querySelector('.search');
    if (searchSelector) {
        searchSelector.addEventListener('click', function () {
            searchBox.classList.toggle('open');
        });
    }

})(jQuery);	