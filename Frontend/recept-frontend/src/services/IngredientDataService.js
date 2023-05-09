import axios from "axios";

class IngredientDataService {
    getAllIngredienten() {
        return axios.get("https://localhost:7041/api/Ingredient");
    }
    removeIngredient(id){
        return axios.delete(`https://localhost:7041/api/Ingredient/${id}`);
    }
    createIngredient(naam){
        const ingredient ={
            naam: naam
        };
        return axios.post("https://localhost:7041/api/Ingredient", ingredient)
    }
    updateIngredient(ingredient){
        return axios.put("https://localhost:7041/api/Ingredient", ingredient)
    }
}

export default new IngredientDataService();