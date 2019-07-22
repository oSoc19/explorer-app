import translations from '../assets/translations.json'

class Translation{
    static Translate(key){
        let language = localStorage.getItem("language");
        language = language.toUpperCase();
        return translations[key][language];
    }
}

export default Translation;