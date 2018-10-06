var obj = {},
    enterBtn = document.getElementById('enterBtn'),
    yourInput = document.getElementById('yourInput');

enterBtn.onclick = function () {
    var input = yourInput.value;
    // Don't add anything to the obj if the input is empty.
    if(!input) return;
    // Use brackets to add a property to the obj, and set the value to be the same
    // as the property name.
    obj[input] = input;
    document.write(obj);
};