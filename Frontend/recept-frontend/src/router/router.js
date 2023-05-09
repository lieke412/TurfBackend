import { createWebHistory, createRouter } from "vue-router"
import IngredientenList from "@/components/IngredientenList"
import ReceptenList from "@/components/ReceptenList"
2
const routes = [
  {
    path: "/Ingredient",
    name: "Ingredient",
    component: IngredientenList,
  },
  {
    path: "/Recept",
    name: "Recept",
    component: ReceptenList,
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router