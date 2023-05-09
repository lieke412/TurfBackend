<template>
  <div class="bodyDiv">
    <h1>Ingredienten:</h1>
    <form @submit.prevent="createIngredient">
      Add ingredient
      <input v-model="naam" />
      <button v-if="naam != ''">Add</button>
    </form>
    <br>
    <div v-for="(ingredient, index) in ingredienten" :key="ingredient.id">
      <div class="tableIndex">
        <div class="insideTable">
          <form v-if="ingredient.edit" @submit.prevent="updateIngredient(ingredient)"
            class="formTable">
            <input v-model="ingredient.naam" placeholder="x" />
            <div class="saveTable">
              <button>Save</button>
            </div>
          </form>
          <p v-else>{{ ingredient.naam }}</p>
        </div>
        <div class="divRemove">
          <button @click="removeIngredient(ingredient.id)" v-if="!ingredient.edit">x</button>
          <button @click="changeLabel(index)" v-if="!ingredient.edit">Edit</button>
        </div>
      </div>
    </div>
  </div>
</template>
  
<script>
import ingredientDataService from "@/services/IngredientDataService.js";
//import { ModalPlugin } from "bootstrap-vue";
//import { Modal } from 'usemodal-vue3'

export default {
    name: "IngredientenList",
    data() {
        return {
            ingredienten: [],
            naam: "",
            modalVisible: false,
        };
    },
    methods: {
        changeLabel(index) {
            this.ingredienten[index].edit = true;
        },
        updateIngredient(ingredient) {
            ingredientDataService.updateIngredient(ingredient).then(() => {
                ingredient.edit = false;
            });
        },
        refreshIngredienten() {
            ingredientDataService.getAllIngredienten().then((response) => {
                this.ingredienten = response.data;
            });
        },
        removeIngredient(id) {
            ingredientDataService.removeIngredient(id).then(() => {
                this.refreshIngredienten();
            });
        },
        createIngredient() {
            if (this.naam == "") {
                this.modalVisible != this.modalVisible;
            }
            else {
                ingredientDataService.createIngredient(this.naam).then(() => {
                    this.naam = "";
                    this.refreshIngredienten();
                });
            }
        },
    },
    created() {
        this.refreshIngredienten();
    }
};
</script>
  
<style></style>
  