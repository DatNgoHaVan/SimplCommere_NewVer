/*global jQuery, noUiSlider, wNumb, window, document, productFilter*/
(function ($, currentSearchOption, priceSetting) {
    $(function () {
        function createUrl() {
            var key,
                value,
                newUrl,
                params = [],
                baseUrl = window.location.protocol + '//' + window.location.host + window.location.pathname;

            for (key in currentSearchOption) {
                if (currentSearchOption.hasOwnProperty(key) && currentSearchOption[key]) {
                    value = currentSearchOption[key];
                    params.push(key + '=' + value);
                }
            }

            if (params.length > 0) {
                newUrl = baseUrl + '?' + params.join('&');
            } else {
                newUrl = baseUrl;
            }

            return newUrl;
        }

        function initPriceSlider() {
            var priceSlider = document.getElementById('priceSlider');
            if (!priceSlider) {
                return;
            }
            var priceValues = [
                document.getElementById('minPrice'),
                document.getElementById('maxPrice')
            ];

            noUiSlider.create(priceSlider, {
                connect: true,
                start: [priceSetting.currentMin, priceSetting.currentMax],
                range: {
                    'min': priceSetting.min,
                    'max': priceSetting.max
                },
                format: wNumb({
                    decimals: 3,
                    thousand: '.'
                })
            });

            priceSlider.noUiSlider.on('update', function (values, handle) {
                priceValues[handle].innerHTML = values[handle];
            });

            priceSlider.noUiSlider.on('change', function () {
                var min, max, prices;
                prices = priceSlider.noUiSlider.get();
                min = parseInt(prices[0].replace(/\./g, ''), 10);
                max = parseInt(prices[1].replace(/\./g, ''), 10);
                if (min !== priceSetting.min) {
                    currentSearchOption.minPrice = min;
                } else {
                    currentSearchOption.minPrice = null;
                }
                if (max !== priceSetting.max) {
                    currentSearchOption.maxPrice = max;
                } else {
                    currentSearchOption.maxPrice = null;
                }
                window.location = createUrl();
            });
        }

        // function initRatingSlider() {
        //     var ratingSlider = document.getElementById('ratingSlider');
        //     if (!ratingSlider) {
        //         return;
        //     }
        //     var ratingValues = [
        //         document.getElementById('minRating'),
        //         document.getElementById('maxRating')
        //     ];

        //     noUiSlider.create(ratingSlider, {
        //         connect: true,
        //         start: [ratingSetting.currentMin, ratingSetting.currentMax],
        //         range: {
        //             'min': ratingSetting.min,
        //             'max': ratingSetting.max
        //         }
        //         // format: wNumb({
        //         //     decimals: 2,
        //         //     thousand: '.'
        //         // })
        //     });

        //     ratingSlider.noUiSlider.on('update', function (values, handle) {
        //         ratingValues[handle].innerHTML = values[handle];
        //     });

        //     ratingSlider.noUiSlider.on('change', function () {
        //         var min, max, ratings;
        //         ratings = ratingSlider.noUiSlider.get();
        //         min = parseInt(ratings[0].replace(/\./g, ''), 10);
        //         max = parseInt(ratings[1].replace(/\./g, ''), 10);
        //         if (min !== ratingSetting.min) {
        //             currentSearchOption.minRating = min;
        //         } else {
        //             currentSearchOption.minRating = null;
        //         }
        //         if (max !== ratingSetting.max) {
        //             currentSearchOption.maxRating = max;
        //         } else {
        //             currentSearchOption.maxRating = null;
        //         }
        //         window.location = createUrl();
        //     });
        // }

        $('#collapse-brand input:checkbox').on('change', function () {
            var index,
                checkbox = $(this),
                brand = checkbox.val(),
                brands = currentSearchOption.brand ? currentSearchOption.brand.split('--') :[];
            if (checkbox.prop("checked") === true) {
                brands.push(brand);
            } else {
                index = brands.indexOf(brand);
                brands.splice(index, 1);
            }
            currentSearchOption.brand = brands.join('--');

            window.location = createUrl();
        });

        $('#collapse-category input:checkbox').on('change', function () {
            var index,
                checkbox = $(this),
                category = checkbox.val(),
                categories = currentSearchOption.category ? currentSearchOption.category.split('--') : [];
            if (checkbox.prop("checked") === true) {
                categories.push(category);
            } else {
                index = categories.indexOf(category);
                categories.splice(index, 1);
            }
            currentSearchOption.category = categories.join('--');

            window.location = createUrl();
        });

        $('.sort-by select').on('change', function () {
            currentSearchOption.sort = $(this).val();
            window.location = createUrl();
        });

        initPriceSlider();
        
    });
})(jQuery, productFilter.currentSearchOption, productFilter.priceSetting);