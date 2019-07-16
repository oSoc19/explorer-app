const BASE_URL = "https://localhost:5001/api";

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