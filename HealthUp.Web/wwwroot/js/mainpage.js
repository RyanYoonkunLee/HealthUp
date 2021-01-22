    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
    var slides = document.getElementsByClassName("mySlides");

    for (i = 0; i < slides.length; i++) {
        slides[i].style.opacity = '0';
        slides[i].style.display = 'none';
        slides[i].style.transition = '0.5s linear';
    }
    slideIndex++;


    slides[slideIndex - 1].style.opacity = '1';
    slides[slideIndex - 1].style.transition = '0.5s linear 0.5s';
    slides[slideIndex - 1].style.display = 'block';


    setTimeout(showSlides, 5000);
            if (slideIndex == slides.length) {
            slideIndex = 0;
        }
    }

    var slideIndex1 = 1;
    showSlides1(slideIndex1);
    
    function plusSlides(n) {
            showSlides1(slideIndex1 += n);
    }

    function currentSlide(n) {
            showSlides1(slideIndex1 = n);
    }

    function showSlides1(n) {
        var i;
        var slides1 = document.getElementsByClassName("newproduct");
        var dots = document.getElementsByClassName("dot");
        if (n > slides1.length) {slideIndex1 = 1}
        if (n < 1) {slideIndex1 = slides1.length}
        for (i = 0; i < slides1.length; i++) {
            slides1[i].style.display = "none";
    }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        dots[i].style.backgroundColor = "#bbb";
    }
    slides1[slideIndex1 - 1].style.display = "block";
    dots[slideIndex1 - 1].className += " active";
    dots[slideIndex1 - 1].style.backgroundColor = "#fff";
}

    $(document).ready(function () {
    var itemsMainDiv = ('.MultiCarousel');
    var itemsDiv = ('.MultiCarousel-inner');
    var itemWidth = "";
    
    $('.leftLst, .rightLst').click(function () {
        var condition = $(this).hasClass("leftLst");
        if (condition)
            click(0, this);
        else
            click(1, this)
    });

    ResCarouselSize();




    $(window).resize(function () {
            ResCarouselSize();
    });

    //this function define the size of the items
    function ResCarouselSize() {
        var incno = 0;
        var dataItems = ("data-items");
        var itemClass = ('.item');
        var id = 0;
        var btnParentSb = '';
        var itemsSplit = '';
        var sampwidth = $(itemsMainDiv).width();
        var bodyWidth = $('body').width();
        $(itemsDiv).each(function () {
            id = id + 1;
        var itemNumbers = $(this).find(itemClass).length;
        btnParentSb = $(this).parent().attr(dataItems);
        itemsSplit = btnParentSb.split(',');
        $(this).parent().attr("id", "MultiCarousel" + id);


            if (bodyWidth >= 877) {
            incno = 3;
        itemWidth = sampwidth / incno;
    }
            else if (bodyWidth >= 500) {
            incno = 2;
        itemWidth = sampwidth / incno;
    }
            else {
            incno = itemsSplit[0];
        itemWidth = sampwidth / incno;
    }
            $(this).css({'transform': 'translateX(0px)', 'width': itemWidth * itemNumbers });
            $(this).find(itemClass).each(function () {
            $(this).outerWidth(itemWidth);
    });

    $(".leftLst").addClass("over");
    $(".rightLst").removeClass("over");

});
}


//this function used to move the items
    function ResCarousel(e, el, s) {
        var leftBtn = ('.leftLst');
        var rightBtn = ('.rightLst');
        var translateXval = '';
        var divStyle = $(el + ' ' + itemsDiv).css('transform');
        var values = divStyle.match(/-?[\d\.]+/g);
        var xds = Math.abs(values[4]);
        if (e == 0) {
            translateXval = parseInt(xds) - parseInt(itemWidth * s);
        $(el + ' ' + rightBtn).removeClass("over");

            if (translateXval <= itemWidth / 2) {
            translateXval = 0;
        $(el + ' ' + leftBtn).addClass("over");
    }
}
        else if (e == 1) {
            var itemsCondition = $(el).find(itemsDiv).width() - $(el).width();
        translateXval = parseInt(xds) + parseInt(itemWidth * s);
        $(el + ' ' + leftBtn).removeClass("over");

            if (translateXval >= itemsCondition - itemWidth / 2) {
            translateXval = itemsCondition;
        $(el + ' ' + rightBtn).addClass("over");
    }
}
$(el + ' ' + itemsDiv).css('transform', 'translateX(' + -translateXval + 'px)');
}

//It is used to get some elements from btn
    function click(ell, ee) {
        var Parent = "#" + $(ee).parent().attr("id");
        var slide = $(Parent).attr("data-slide");
        ResCarousel(ell, Parent, slide);
    }

    });
