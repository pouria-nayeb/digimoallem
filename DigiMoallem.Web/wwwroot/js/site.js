﻿function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#display-image').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#image").change(function (event) {
    var fileName = event.target.files[0].name;
    if (fileName.length > 0) {
        $(this).next().text(fileName);
    }
    readURL(this);
});

$("#cv").change(function (event) {
    var fileName = event.target.files[0].name;
    if (fileName.length > 0) {
        $(this).next().text(fileName);
    }
});