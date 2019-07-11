const BASE_URL = "https://localhost:5001/api";

class Api{
    constructor(){
    }

    static async getPaintingDetail(id){
        let data = null;    
        let response = await fetch(`${BASE_URL}/painting/${id}`);
        data = await response.json();
        return data;
    }
}

export default Api;