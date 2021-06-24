$("#addRow").click(function () {
    calibrateIndexes();

    let inputRowIndex = getLastIndex() + 1;

    let html = '';
    html += '<div id="inputFormRow" class="inputRowIndex">';
    html += '<div class="input-group row p-2 mb-2"  id="InputFormRowBlock">';
    html += '<input type="text" id="TestValues[' + inputRowIndex + '].Input" name="TestValues[' + inputRowIndex + '].Input" class="form-control m-input col m-1" placeholder="Входные данные" autocomplete="off">';
    html += '<input type="text" id="TestValues[' + inputRowIndex + '].Output" name="TestValues[' + inputRowIndex + '].Output" class="form-control m-input col m-1" placeholder="Выходные данные" autocomplete="off">';
    html += '<div class="input-group-append col-1">';
    html += '<button id="removeRow" type="button" class="btn bgDanger m-1">Удалить</button>';
    html += '</div>';
    html += '</div>';
    html += '</div>';

    $('#newRow').append(html);
});

$(document).on('click', '#removeRow', function () {
    let parentNode = $(this).closest('#inputFormRow');
    parentNode.remove();

    calibrateIndexes();
});

function calibrateIndexes() {
    let inputFormRows = $('[id^=InputFormRowBlock]');

    for (let i = 0; i < inputFormRows.length; i++) {
        $(inputFormRows[i]).children('input').each(function () {
            let inputType = this.name.split('.')[1];
            let inputId;

            switch (inputType) {
                case "Input":
                    inputId = 'TestValues[' + i + '].Input';
                    break;
                case "Output":
                    inputId = 'TestValues[' + i + '].Output';
                    break;
            }

            this.name = inputId;
            this.id = inputId;
        });
    }
}


function getLastIndex() {
    return $('[id^=InputFormRowBlock]').length - 1;
}