import React from 'react';
import Logo from '../../assets/images/logo_brugge.svg';
import styles from './choose-language.module.css';
import ReactNotification from "react-notifications-component";
import "react-notifications-component/dist/theme.css";
import Api from '../../services/api';
import Translation from '../../services/translation';

class ChooseLanguage extends React.Component{

    constructor(props){
        super(props);
        let fullLanguage = navigator.language || navigator.userLanguage;
        this.language = fullLanguage.substring(0, 2);
        this.state = {
            language : this.language,
            languages : []
        };

        this.notificationDOMRef = React.createRef();
        this.selectLanguage = this.selectLanguage.bind(this);
        this.isoLanguages = this.isoLanguages =  [
            ["aa","Afar","Afar"],
            ["ab","Abkhazian","Аҧсуа"],
            ["af","Afrikaans","Afrikaans"],
            ["ak","Akan","Akana"],
            ["am","Amharic","አማርኛ"],
            ["an","Aragonese","Aragonés"],
            ["ar","Arabic","العربية"],
            ["as","Assamese","অসমীয়া"],
            ["av","Avar","Авар"],
            ["ay","Aymara","Aymar"],
            ["az","Azerbaijani","Azərbaycanca / آذربايجان"],
            ["ba","Bashkir","Башҡорт"],
            ["be","Belarusian","Беларуская"],
            ["bg","Bulgarian","Български"],
            ["bh","Bihari","भोजपुरी"],
            ["bi","Bislama","Bislama"],
            ["bm","Bambara","Bamanankan"],
            ["bn","Bengali","বাংলা"],
            ["bo","Tibetan","བོད་ཡིག / Bod skad"],
            ["br","Breton","Brezhoneg"],
            ["bs","Bosnian","Bosanski"],
            ["ca","Catalan","Català"],
            ["ce","Chechen","Нохчийн"],
            ["ch","Chamorro","Chamoru"],
            ["co","Corsican","Corsu"],
            ["cr","Cree","Nehiyaw"],
            ["cs","Czech","Česky"],
            ["cu","Old Church Slavonic / Old Bulgarian","словѣньскъ / slověnĭskŭ"],
            ["cv","Chuvash","Чăваш"],
            ["cy","Welsh","Cymraeg"],
            ["da","Danish","Dansk"],
            ["de","German","Deutsch"],
            ["dv","Divehi","ދިވެހިބަސް"],
            ["dz","Dzongkha","ཇོང་ཁ"],
            ["ee","Ewe","Ɛʋɛ"],
            ["el","Greek","Ελληνικά"],
            ["en","English","English"],
            ["eo","Esperanto","Esperanto"],
            ["es","Spanish","Español"],
            ["et","Estonian","Eesti"],
            ["eu","Basque","Euskara"],
            ["fa","Persian","فارسی"],
            ["ff","Peul","Fulfulde"],
            ["fi","Finnish","Suomi"],
            ["fj","Fijian","Na Vosa Vakaviti"],
            ["fo","Faroese","Føroyskt"],
            ["fr","French","Français"],
            ["fy","West Frisian","Frysk"],
            ["ga","Irish","Gaeilge"],
            ["gd","Scottish Gaelic","Gàidhlig"],
            ["gl","Galician","Galego"],
            ["gn","Guarani","Avañe'ẽ"],
            ["gu","Gujarati","ગુજરાતી"],
            ["gv","Manx","Gaelg"],
            ["ha","Hausa","هَوُسَ"],
            ["he","Hebrew","עברית"],
            ["hi","Hindi","हिन्दी"],
            ["ho","Hiri Motu","Hiri Motu"],
            ["hr","Croatian","Hrvatski"],
            ["ht","Haitian","Krèyol ayisyen"],
            ["hu","Hungarian","Magyar"],
            ["hy","Armenian","Հայերեն"],
            ["hz","Herero","Otsiherero"],
            ["ia","Interlingua","Interlingua"],
            ["id","Indonesian","Bahasa Indonesia"],
            ["ie","Interlingue","Interlingue"],
            ["ig","Igbo","Igbo"],
            ["ii","Sichuan Yi","ꆇꉙ / 四川彝语"],
            ["ik","Inupiak","Iñupiak"],
            ["io","Ido","Ido"],
            ["is","Icelandic","Íslenska"],
            ["it","Italian","Italiano"],
            ["iu","Inuktitut","ᐃᓄᒃᑎᑐᑦ"],
            ["ja","Japanese","日本語"],
            ["jv","Javanese","Basa Jawa"],
            ["ka","Georgian","ქართული"],
            ["kg","Kongo","KiKongo"],
            ["ki","Kikuyu","Gĩkũyũ"],
            ["kj","Kuanyama","Kuanyama"],
            ["kk","Kazakh","Қазақша"],
            ["kl","Greenlandic","Kalaallisut"],
            ["km","Cambodian","ភាសាខ្មែរ"],
            ["kn","Kannada","ಕನ್ನಡ"],
            ["ko","Korean","한국어"],
            ["kr","Kanuri","Kanuri"],
            ["ks","Kashmiri","कश्मीरी / كشميري"],
            ["ku","Kurdish","Kurdî / كوردی"],
            ["kv","Komi","Коми"],
            ["kw","Cornish","Kernewek"],
            ["ky","Kirghiz","Kırgızca / Кыргызча"],
            ["la","Latin","Latina"],
            ["lb","Luxembourgish","Lëtzebuergesch"],
            ["lg","Ganda","Luganda"],
            ["li","Limburgian","Limburgs"],
            ["ln","Lingala","Lingála"],
            ["lo","Laotian","ລາວ / Pha xa lao"],
            ["lt","Lithuanian","Lietuvių"],
            ["lv","Latvian","Latviešu"],
            ["mg","Malagasy","Malagasy"],
            ["mh","Marshallese","Kajin Majel / Ebon"],
            ["mi","Maori","Māori"],
            ["mk","Macedonian","Македонски"],
            ["ml","Malayalam","മലയാളം"],
            ["mn","Mongolian","Монгол"],
            ["mo","Moldovan","Moldovenească"],
            ["mr","Marathi","मराठी"],
            ["ms","Malay","Bahasa Melayu"],
            ["mt","Maltese","bil-Malti"],
            ["my","Burmese","Myanmasa"],
            ["na","Nauruan","Dorerin Naoero"],
            ["nd","North Ndebele","Sindebele"],
            ["ne","Nepali","नेपाली"],
            ["ng","Ndonga","Oshiwambo"],
            ["nl","Dutch","Nederlands"],
            ["nn","Norwegian Nynorsk","Norsk (nynorsk)"],
            ["no","Norwegian","Norsk (bokmål / riksmål)"],
            ["nr","South Ndebele","isiNdebele"],
            ["nv","Navajo","Diné bizaad"],
            ["ny","Chichewa","Chi-Chewa"],
            ["oc","Occitan","Occitan"],
            ["oj","Ojibwa","ᐊᓂᔑᓈᐯᒧᐎᓐ / Anishinaabemowin"],
            ["om","Oromo","Oromoo"],
            ["or","Oriya","ଓଡ଼ିଆ"],
            ["os","Ossetian / Ossetic","Иронау"],
            ["pa","Panjabi / Punjabi","ਪੰਜਾਬੀ / पंजाबी / پنجابي"],
            ["pi","Pali","Pāli / पाऴि"],
            ["pl","Polish","Polski"],
            ["ps","Pashto","پښتو"],
            ["pt","Portuguese","Português"],
            ["qu","Quechua","Runa Simi"],
            ["rm","Raeto Romance","Rumantsch"],
            ["rn","Kirundi","Kirundi"],
            ["ro","Romanian","Română"],
            ["ru","Russian","Русский"],
            ["rw","Rwandi","Kinyarwandi"],
            ["sa","Sanskrit","संस्कृतम्"],
            ["sc","Sardinian","Sardu"],
            ["sd","Sindhi","सिनधि"],
            ["se","Northern Sami","Sámegiella"],
            ["sg","Sango","Sängö"],
            ["sh","Serbo-Croatian","Srpskohrvatski / Српскохрватски"],
            ["si","Sinhalese","සිංහල"],
            ["sk","Slovak","Slovenčina"],
            ["sl","Slovenian","Slovenščina"],
            ["sm","Samoan","Gagana Samoa"],
            ["sn","Shona","chiShona"],
            ["so","Somalia","Soomaaliga"],
            ["sq","Albanian","Shqip"],
            ["sr","Serbian","Српски"],
            ["ss","Swati","SiSwati"],
            ["st","Southern Sotho","Sesotho"],
            ["su","Sundanese","Basa Sunda"],
            ["sv","Swedish","Svenska"],
            ["sw","Swahili","Kiswahili"],
            ["ta","Tamil","தமிழ்"],
            ["te","Telugu","తెలుగు"],
            ["tg","Tajik","Тоҷикӣ"],
            ["th","Thai","ไทย / Phasa Thai"],
            ["ti","Tigrinya","ትግርኛ"],
            ["tk","Turkmen","Туркмен / تركمن"],
            ["tl","Tagalog / Filipino","Tagalog"],
            ["tn","Tswana","Setswana"],
            ["to","Tonga","Lea Faka-Tonga"],
            ["tr","Turkish","Türkçe"],
            ["ts","Tsonga","Xitsonga"],
            ["tt","Tatar","Tatarça"],
            ["tw","Twi","Twi"],
            ["ty","Tahitian","Reo Mā`ohi"],
            ["ug","Uyghur","Uyƣurqə / ئۇيغۇرچە"],
            ["uk","Ukrainian","Українська"],
            ["ur","Urdu","اردو"],
            ["uz","Uzbek","Ўзбек"],
            ["ve","Venda","Tshivenḓa"],
            ["vi","Vietnamese","Tiếng Việt"],
            ["vo","Volapük","Volapük"],
            ["wa","Walloon","Walon"],
            ["wo","Wolof","Wollof"],
            ["xh","Xhosa","isiXhosa"],
            ["yi","Yiddish","ייִדיש"],
            ["yo","Yoruba","Yorùbá"],
            ["za","Zhuang","Cuengh / Tôô / 壮语"],
            ["zh","Chinese","中文"],
            ["zu","Zulu","isiZulu"]
          ];
          this.languageOptions = [];
          
          this.englishLanguageOption = this.getEnglishLanguageName(this.isoLanguages, this.state.language);
          this.i = 0;
          for (this.i = 0; this.i < this.isoLanguages.length ; this.i++) {
                let isoCode = this.isoLanguages[this.i][0];
                isoCode = isoCode.toUpperCase();
                this.languageOptions.push(<option key={this.isoLanguages[this.i][0]} id={isoCode} value={this.isoLanguages[this.i][1]}>{this.isoLanguages[this.i][2]}</option>)
          }

          
    }

    async componentWillMount(){
        if(this.props.location.state !== undefined && this.props.location.state.isLanguageMissing){
            let languages = await Api.getAvailableLanguages();
            await this.setState({
                language : this.language,
                languages : languages
            });
        }
    }

    getEnglishLanguageName(array, item) {
        for (let i = 0; i < array.length; i++) {
            if (array[i][0] == item) {
                return array[i][1];   // Found it
            }
        }
        return false;   // Not found
    }

    selectLanguage(dropdown){
        let language = "";
        if(typeof(dropdown) !== "string"){
            language = dropdown.target.options[dropdown.target.selectedIndex].getAttribute('id');
        }else{
            language = dropdown.toUpperCase();
        }
        
        localStorage.setItem("preferred-language", language);
        localStorage.setItem("language", language);
        this.props.history.push(`/${this.props.location.state === undefined? 'choose-painting' : this.props.location.state.previousUrl}`);
    }

    renderAllLanguages(){
        return(
            <div className="dropdown-placeholder">
                <select defaultValue={this.englishLanguageOption} id="language-select" className={`${styles.dropdown}`} onChange={e=>this.selectLanguage(e)}>
                    {this.languageOptions}
                </select>
                <i id={this.state.language} className={`selectableLanguage fas fa-arrow-circle-right fa-3x ${styles.nextButton}`} onClick={()=>this.selectLanguage(this.state.language)}><span>{this.englishLanguageOption}</span></i>
            </div>
        );


    }

    renderMostUsedLanguages(){
        return(
        <tbody>
            <tr>
                <td id='EN' className="selectableLanguage" onClick={()=>this.selectLanguage('EN')}>English</td>
                <td id='DE' className="selectableLanguage" onClick={()=>this.selectLanguage('DE')}>Deutsch</td>
            </tr>
            <tr>
                <td id='NL' className="selectableLanguage" onClick={()=>this.selectLanguage('NL')}>Nederlands</td>
                <td id='ES' className="selectableLanguage" onClick={()=>this.selectLanguage('ES')}>Espanol</td>
            </tr>
            <tr>
                <td id='FR' className="selectableLanguage" onClick={()=>this.selectLanguage('FR')}>Français</td>
                <td id='IT' className="selectableLanguage" onClick={()=>this.selectLanguage('IT')}>Italiano</td>
            </tr>
            <tr>
                <td id='JA' className="selectableLanguage" onClick={()=>this.selectLanguage('JA')}>日本の</td>
                <td id='RU' className="selectableLanguage" onClick={()=>this.selectLanguage('RU')}>русский</td>
            </tr>
        </tbody>
        );
    }

    render(){
        return(
            <div className="container">
                <ReactNotification ref={this.notificationDOMRef} />
                <div className="row header">
                    <div className="col align-self-top bruggeLogo">
                        <img alt="Brugge logo" src={Logo} ></img>
                    </div>
                </div>
                <div className={styles.containerLanguages}>
                    <h6 className={`${styles.title}`}>
                        Select your language
                    </h6>
                    {this.renderAllLanguages()} 
                    
                    <hr className={styles.line}/>
                    <table className={`table table-borderless align-middle`}>
                        {this.renderMostUsedLanguages()}
                    </table>
                </div>
            </div>
        );
    }
}

export default ChooseLanguage;