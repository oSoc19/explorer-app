import translations from '../assets/translations.json'

class Translation{
    static Translate(key){
        let language = localStorage.getItem("language");
        language = language.toUpperCase();
        if( language!== 'EN' && language!== 'NL' && language!== 'FR' && language!== 'DE' && language!== 'ES' && language!== 'IT' && language!== 'JA' && language!== 'RU' ){
            language = 'EN';
        }
        return translations[key][language];
    }
}

export default Translation;