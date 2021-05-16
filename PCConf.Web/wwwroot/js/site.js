// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function filterData(e) {
    let data = {};
    if (e.filter.filters && e.filter.filters.length > 0) {
        for (let i = 0; i < e.filter.filters.length; i++) {
            let fieldName = e.filter.filters[i].field.toUpperCase() === "name".toUpperCase()
                || e.filter.filters[i].field.toUpperCase() === "fullname".toUpperCase()
                ? "text"
                : e.filter.filters[i].field;
            data[fieldName] = e.filter.filters[i].value;
        }
    }

    return data;
}

function cascadeCases(e) {

    let mbDropDown = $("#motherborads").data("kendoDropDownList");
    let vcDropDown = $("#videocards").data("kendoDropDownList");
    let casesDropDown = $("#cases").data("kendoDropDownList");

    if (mbDropDown.value() && vcDropDown.value()) {
        casesDropDown.enable(true);

        requestOptional(
            "GetCases",
            "Configurator",
            {
                data: {
                    mbId: mbDropDown.value(),
                    gpuId: vcDropDown.value()
                },
                success: function (data) {
                    if (!data) {
                        return;
                    }

                    casesDropDown.setDataSource(new kendo.data.DataSource({
                        data
                    }));
                }
            });

    }
    else {
        casesDropDown.value("");
        casesDropDown.enable(false);
    }
}

function requestOptional(action, controller, optional) {

    if (optional === null) {
        optional = {};
    }

    let isPost = typeof optional.type !== 'undefined' && optional.type !== null && ["POST", "DELETE"].indexOf(optional.type.toUpperCase()) > -1;
    let ajaxSettings = {
        data: isPost
            ? JSON.stringify(optional.data)
            : optional.data,
        contentType: optional.contentType ? optional.contentType : "application/json; charset=utf-8",
        headers: isPost
            ? { "__RequestVerificationToken": $("input[name='__RequestVerificationToken']:first").val() }
            : null, // Add __RequestVerificationToken for POST ajax request
        success: function (d, e, t) {
            if (optional.success) {
                optional.success(d, e, t);
            }
        },
        error: function (d, e, t) {
            if (optional.error) {
                optional.error(d, e, t);
            }
        },
        complete: function (d, e) {
            if (optional.complete) {
                optional.complete(d, e);
            }
        },
        async: (typeof optional.async === "undefined" || optional.async === null) ? true : optional.async,
        type: optional.type || "GET",
        traditional: optional.traditional === true,
        global: (typeof optional.global === "undefined" || optional.global === null) ? true : optional.global,
        cache: optional.cache
    };

    return $.ajax(
        getPathToActionMethod(
            action,
            controller,
            {
                area: optional.area,
                useArea: optional.useArea
            }),
        ajaxSettings
    );

}

function getPathToActionMethod(action, controller, area, useArea) {
    if ((!useArea == undefined || useArea === true) && area) {
        return "/" + area + "/" + controller + "/" + action + "/";
    }

    return controller + "/" + action + "/";
}

function onClosePartDropDown() {
    let dropDowns = getDropDowns();
    let textBox = $("#configurationPrice").data("kendoNumericTextBox");

    let total = 0;
    for (var i = 0; i < dropDowns.length; i++) {
        total += dropDowns[i].dataItem().price && dropDowns[i].dataItem().price != "" ? parseFloat(dropDowns[i].dataItem().price) : 0
    }

    textBox.value(parseFloat(total).toFixed(2));

}

function getDropDowns() {

    let dropDownDOMelements = $(".k-dropdown");
    let dropDowns = [];

    dropDownDOMelements.each(function (ddl) {
        let currentAriaOwnsAttribute = $(this)[0].attributes[7].nodeValue;
        let currentDropDownListName = currentAriaOwnsAttribute.substring(0, currentAriaOwnsAttribute.length - 8);

        let currentDropDownList = $('#' + currentDropDownListName).data("kendoDropDownList");
        dropDowns.push(currentDropDownList);

    });

    return dropDowns;
}