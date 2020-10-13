
let event = new Event('ScriptsCarregados');

let _scriptsToLoad = [
    ScriptSource + 'jquery-3.5.1.min.js',
    ScriptSource + 'bootstrap.bundle.js',
    ScriptSource + 'jquery.inputmask.js',
    ScriptSource + 'jquery-ui.min.js',
    ScriptSource + 'bootstrap-select.js',
    ScriptSource + 'sweetalert2.all.js',
    ScriptSource + 'Cookies.js',
    ScriptSource + 'default.js'
];

function createScriptElement() {
    // gets the first script in the list
    let script = _scriptsToLoad.shift();
    // all scripts were loaded
    if (!script)
    {
        document.dispatchEvent(event);
        return;
    }
    let js = document.createElement('script');
    js.type = 'text/javascript';
    js.src = script;
    js.onload = onScriptLoaded;
    let s = document.getElementsByTagName('script')[0];
    s.parentNode.insertBefore(js, s);
}

function onScriptLoaded(event) {
    // loads the next script
    createScriptElement();
};


createScriptElement();