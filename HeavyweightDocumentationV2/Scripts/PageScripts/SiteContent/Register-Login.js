$("#no-DB-message").dialog({
    modal: true,
    draggable: false,
    buttons: { Ok: function () { $(this).dialog("close"); } }
});


$("#aboutProgressAccordion").accordion(
 {
     active: false,
     heightStyle: "content",
     collapsible: true,
     icons: { "header": "ui-icon-plus", "activeHeader": "ui-icon-minus" }
 }
);


