import { IProductDto } from './../../../shared/service-proxies/service-proxies';
import { CustomerBasketService } from './../customer-basket/customer-basket.service';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ProductBrandDto, ProductBrandServiceProxy, ProductColorDto, ProductColorServiceProxy, ProductDto, ProductServiceProxy, ProductTypeDto, ProductTypeServiceProxy, CustomerBasketServiceProxy } from '@shared/service-proxies/service-proxies';
import { CustomerBasketComponent } from '../customer-basket/customer-basket.component';


@Component({
  selector: 'app-customer-products',
  templateUrl: './customer-products.component.html',
  styleUrls: ['./customer-products.component.css']
})
export class CustomerProductsComponent implements OnInit {

  products: ProductDto[] = []
  brands: ProductBrandDto[] = []
  types: ProductTypeDto[] = []
  colors: ProductColorDto[] = []

  product: ProductDto = new ProductDto()

  constructor(
    private productService: ProductServiceProxy,
    private brandService: ProductBrandServiceProxy,
    private typeService: ProductTypeServiceProxy,
    private colorService: ProductColorServiceProxy,
    private customerBasketService: CustomerBasketService) { }

  ngOnInit(): void {
    this.getAllProducts()
    this.getAllBrands()
    this.getAllTypes()
    this.getAllColors()
  }

  addToBasket(product: ProductDto) {
    console.log("product", product)
    this.customerBasketService.addItemToBasket(product)
  }

  getAllProducts() {
    this.productService.getAllProducts().subscribe(response => {
      this.products = response
    })
  }

  getAllBrands() {
    this.brandService.getAllBrands().subscribe(response => {
      this.brands = response
    })
  }

  getAllTypes() {
    this.typeService.getAllTypes().subscribe(response => {
      this.types = response
    })
  }

  getAllColors() {
    this.colorService.getAllColors().subscribe(response => {
      this.colors = response
    })
  }

  getAllProductsByBrandId(productBrandId: number) {
    this.productService.getAllProductsByBrand(productBrandId).subscribe(response => {
      this.products = response
    })
  }

  getAllProductsByTypeId(productTypeId: number) {
    this.productService.getAllProductsByType(productTypeId).subscribe(response => {
      this.products = response
    })
  }

}
