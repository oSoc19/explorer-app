const BASE_URL = "https://localhost:5001/api";

class Api{
    constructor(){
    }

    static async getPaintingDetail(id){
        let response = await fetch(`${BASE_URL}/painting/${id}`);
        let data = await response.json();
        console.log(data);
        return data;
    }
}

export default Api;