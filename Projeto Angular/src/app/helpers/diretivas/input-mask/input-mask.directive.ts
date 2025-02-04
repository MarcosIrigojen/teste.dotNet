import { Directive, Input, ElementRef, Inject, Provider, forwardRef, Renderer } from '@angular/core';
import { NG_VALUE_ACCESSOR } from '@angular/forms';

export const MASK: Provider = {
  provide: NG_VALUE_ACCESSOR,
  useExisting: forwardRef(() => InputMaskDirective),
  multi: true
}

@Directive({
  selector: '[mask]',
  host: {
    '(input)': 'input($event.target.value, $event.target)',
    '(blur)': 'focusout()'
  },
  providers: [MASK]
})

export class InputMaskDirective {

  tmpMascara: any;

  @Input('mask') mascara: string;
  @Input('reqMin') qtdRequiredMin: number;
  @Input('maskkOutput') maskkOutput: boolean = false;

  constructor(@Inject(Renderer) private renderer: Renderer, @Inject(ElementRef) private element: ElementRef) { }

  ngOnChanges(event) {
    if (this.mascara) {
      this.tmpMascara = this.mascara;
    }
  }


  writeValue(value: any) {

    if (value === undefined || value === null) {

      this.propagateChange(null);
      this.renderer.setElementProperty(this.element.nativeElement, 'value', '');

    } else {

      this.input(value);

    }

  }

  propagateChange = (_: any) => { };

  registerOnChange(fn) {
    this.propagateChange = fn;
  }

  public onTouched: any = () => { }

  registerOnTouched(fn: any) {
    this.onTouched = fn;
  }

  input(val, event?) {


    let mascared: string = '';
    let unmask = val.toString().replace(new RegExp(/[^\d]/, 'g'), '');

    let c = 0;
    this.mascara = this.tmpMascara;
    if (this.mascara === 'cpfCnpj') {
      if (unmask.length <= 11) {
        this.mascara = '999.999.999-99';
      }
      else {
        this.mascara = '99.999.999/9999-99';
      }
    }

    for (let i = 0; (i < this.mascara.length) && (c < unmask.length); i++) {

      if (this.mascara.slice(i, i + 1) == '9') {

        mascared += unmask.slice(c, c + 1);
        c++;

      } else {

        mascared += this.mascara.slice(i, i + 1);

      }
    }

    this.propagateChange((this.maskkOutput) ? mascared : mascared.replace(new RegExp(/[^\d]/, 'g'), ''));
    this.renderer.setElementProperty(this.element.nativeElement, 'value', mascared)


    setTimeout(function () {

      if (event !== undefined)
        event.setSelectionRange(mascared.length, mascared.length);

    }, 0);


  }

  focusout() {

    this.onTouched();

    let valCurrentField: string = (this.element.nativeElement.value == undefined) ? '' : this.element.nativeElement.value;

    if (typeof this.qtdRequiredMin !== 'undefined' && valCurrentField.length < this.qtdRequiredMin) {

      this.propagateChange(null);
      this.renderer.setElementProperty(this.element.nativeElement, 'value', '')

    } else if (typeof this.qtdRequiredMin === 'undefined' && valCurrentField.length != this.mascara.length) {

      this.propagateChange(null);
      this.renderer.setElementProperty(this.element.nativeElement, 'value', '')
    }

  }

}
