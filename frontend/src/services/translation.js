import translations from '../assets/translations.json'

class Translation{
    static Translate(key){
        let language = new URLSearchParams(window.location.search).get('language');
        language = language.toUpperCase();
        return translations[key][language];
    }
}

export default Translation;