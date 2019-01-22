// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const shoppingCartStore = new Vuex.Store({
    state: {
        cart: []
    },
    mutations: {
        addToCart(state, item) {
            var found = state.cart.find(product => product.id == item.id);

            if (found) {
                if (found.quantity == null) {
                    found.quantity = 0;
                }

                found.quantity = parseInt(found.quantity) + parseInt(item.quantity);
            } else {
                state.cart.push(item);

                Vue.set(item, 'quantity', item.quantity);
            }
            
            shoppingCartBadgeApp.quantity = state.cart.length;

            $.notify({
                // options
                message: 'Your item <strong>' + item.name + '</strong> has been added to shopping cart!'
            },
            {
                // settings
                type: 'success',
                allow_dismiss: true,
                timer: 500,
            });
        },
        saveCart(state) {
            localStorage.setItem("cart", JSON.stringify(state.cart));
        }
    },
    getters: {
        getCart: state => {
            state.cart = JSON.parse(localStorage.getItem("cart"));
            if (state.cart == null) {
                state.cart = [];
            }

            return state.cart;
        }
    },
});