
var Categories = []

function LoadCategory(element){
    if (Categories.length == 0) {
        $.ajax({
            type: "GET",
            url:'/Order/getProductCategories',
            success: function (data) {
                Categories = data;
                renderCategory(element);
            }
        })
    }
    else {
        renderCategory(element);
    }
}

function renderCategory(element) {
    var $ele = $(element);
    $ele.empty();
    $ele.append($('<option/>').val('0').text('Select'));

    $.each(Categories, function (i, val) {
        $ele.append($('<option/>').val(val.CategoryId).text(val.CatogoryName));
    })
}



function LoadProduct(categoryDD) {

    $.ajax({
        type: "GET",
        url: '/Order/getProducts',
        data: { 'CategoryId': $(categoryDD).val() },
        success: function (data) {
            renderProduct($(categoryDD).parents('.mycontainer').find('select.product'), data);
        },
        error: function (error) {
            console.log(error);
        }
    })
}

function renderProduct(element, data) {
    var $ele = $(element);
    $ele.empty();
    $ele.append($('<option/>').val('0').text('Select'));

    $.each(data, function (i, val) {
        $ele.append($('<option/>').val(val.ProductId).text(val.ProductName));
    })
}



$(document).ready(function () {
    //Add Items
    $("#add").click(function () {
        var isAllValid = ture;

        //Category
        if ($('#productCategory').val() == "0") {
            $('#productCategory').siblings('span.error').css('visibility', 'visible');
        }
        else {
            $('#productCategory').siblings('span.error').css('visibility', 'hidden');
        }

        //Product
        if ($('#product').val() == "0") {
            $('#product').siblings('span.error').css('visibility', 'visible');
        }
        else {
            $('#product').siblings('span.error').css('visibility', 'hidden');
        }

        //Quantity
        if (!($('#quantity').val().trim() != "" && (parseInt($('#quantity').val()) || 0))) {
            isAllValid = false;
            $('#quantity').siblings('span.error').css('visibility', 'visible');
        }
        else {
            $('#quantity').siblings('span.error').css('visibility', 'hidden');
        }
     

        //Unit Price 
        //Quantity
        if (!($('#rate').val().trim() != "" && (parseInt($('#quantity').val()) || 0))) {
            isAllValid = false;
            $('#rate').siblings('span.error').css('visibility', 'visible');
        }
        else {
            $('#rate').siblings('span.error').css('visibility', 'hidden');
        }







        if (isAllValid) {

        }
    })
});


LoadCategory($('#productCategory'));