const BASE_URL = process.env.NODE_ENV === 'development' ? "https://localhost:5001/api":"http://165.22.197.214:8080/api";

class Api{
    static async getPaintingDetail(museumNumber, language){
        let data = null;    
        let response = await fetch(`${BASE_URL}/painting/museum/${museumNumber}?language=${language}`);
        data = await response.json();
        return data;
    }

    static async getAvailableLanguages(){
        let response = await fetch(`${BASE_URL}/language`);
        let data = await response.json();
        return data;
    }
}

export default Api;