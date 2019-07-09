"use strict";
$(document).ready(function() {
    $(".tags_options").select2({
        tags: true,
        tokenSeparators: [',', ' ']
    });

    function validateEditor() {
        // Revalidate the content when its value is changed by Summernote
        $('#add_faq_form').bootstrapValidator('revalidateField', 'content');
    };
    $('#add_faq_form')
        .bootstrapValidator({
            button: {
                selector: '[type="submit"]'
            },
            excluded: [':disabled'],

            fields: {
                title: {
                    validators: {
                        notEmpty: {
                            message: 'The title is required and cannot be empty'
                        }
                    }
                },
                category: {
                    validators: {
                        notEmpty: {
                            message: 'The category is required and cannot be empty'
                        }
                    }
                },
                tags: {
                    validators: {
                        callback: {
                            message: 'The content is required and cannot be empty',
                            callback: function(value, validator, $fild) {
                                var options = validator.getFieldElements('tags').val();
                                return (options != null && options.length >= 1 && options.length <= 10);
                            }
                        }

                    }
                },
                content: {
                    validators: {
                        callback: {
                            message: 'The content is required and cannot be empty',
                            callback: function(value, validator) {
                                var code = $('[name="content"]').code();
                                // <p><br></p> is code generated by Summernote for empty content
                                return (code !== '' && code !== '<p><br></p>');
                            }
                        }
                    }
                }
            },
            submitHandler: function(validator, form, submitButton) {
                alert("Your alert come here");
                validator.defaultSubmit();
            }

        }).on('summernote.change', function() {
            validateEditor();
            $('#add_faq_form').bootstrapValidator('revalidateField', 'content');
        }).on('success.form.bv', function(e) {
            e.preventDefault();
            swal({
                title: "Success.",
                text: "Successfully Submitted",
                type: "success",
                allowOutsideClick: false

            }).then(function() {
                window.location.href = "add_faq.html";

            });
        })
        .find('[name="content"]').summernote({
            height: 200
        })
        .change(function(e) {
            $('#add_faq_form').bootstrapValidation('revalidateField', 'tags');
        }).find('[name="tags"]').select2({
            tags: true
        })
    $('input[type=reset]').on('click', function() {
        $(".note-editable").empty();
        $(".select2-selection__choice").empty().css('border', "0");
        $('#add_faq_form').bootstrapValidator("resetForm");
    });
});
