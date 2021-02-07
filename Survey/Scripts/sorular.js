function addAnswer() {
    var newval = $('#answer_count').val();
    newval++;
    $('#answer_count').val(newval);

    $('#answers').append('Answer #' + newval + ' <input type="text" name="answer' + newval + '" class="form-control" />');
}

function addAnswerImage() {
    var newval = $('#answer_count').val();
    newval++;
    $('#answer_count').val(newval);

    $('#answers_image').append('<hr>Answer #' + newval + ' <input type="text" name="answer_i_' + newval + '" class="form-control" /><br />Image: <input type="file" name="answer_image_' + newval + '" />');
}

function loadCurrent(type) {
    change_form("type_edit", type);
}

$(document).ready(function () {
    $('#type').change(function () {
        reset_form(1);
        change_form("type", $('#type').val());
    });
    $('#type_edit').change(function () {
        reset_form(0);
        change_form("type_edit", $('#type_edit').val());
    });
});


function change_form(id, type) {
    $('#' + id).val(type);
    if (type == 1) {
        // Show
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#potential_answers').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
    } else if (type == 2) {
        // Show
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#potential_answers').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
    } else if (type == 3) {
        // Show
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#potential_answers').css("display", "block");
        $('#star_count').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
    } else if (type == 4) {
        // Show
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#potential_answers').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
    } else if (type == 5) {
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
        $('#potential_answers_image').css("display", "block");
        $('#thumbnail_size_w').css("display", "block");
        $('#thumbnail_size_h').css("display", "block");
    } else if (type == 6) {
        $('#question').css("display", "block");
        $('#question_display').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
        $('#potential_answers_image').css("display", "block");
        $('#thumbnail_size_w').css("display", "block");
        $('#thumbnail_size_h').css("display", "block");
    } else if (type == 7) {
        $('#question').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
        $('#answer_in_1').val("Input Field");
    } else if (type == 8) {
        $('#question').css("display", "block");
        $('#page_display').css("display", "block");
        $('#required_display').css("display", "block");
        $('#answer_in_1').val("Input Field");
    } else if (type == 9) {
        $('#question').css("display", "block");
        $('#page_display').css("display", "block");
        $('#potential_answers').css("display", "block");
        $('#required_display').css("display", "block");
        $('#custom_rating').css("display", "block");
    }
}

function reset_form(id) {
    $('#question').css("display", "none");
    $('#question_display').css("display", "none");
    $('#potential_answers').css("display", "none");
    $('#answer_count').val(1);
    $('#star_count').css("display", "none");
    $('#page_display').css("display", "none");
    $('#required_display').css("display", "none");
    $('#potential_answers_image').css("display", "none");
    $('#thumbnail_size_w').css("display", "none");
    $('#thumbnail_size_h').css("display", "none");
    $('#custom_rating').css("display", "none");
    $('#answer_in_1').val("");
    if (id) {
        $('#answers').html('Answer #1 <input type="text" name="answer1" id="answer_in_1" class="form-control" />');
        $('#answers_image').html('Answer #1 <input type="text" name="answer_i_1" class="form-control" /><br />Image: <input type="file" name="answer_image_1" />');
    }
}