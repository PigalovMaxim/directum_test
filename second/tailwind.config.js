/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,js}", "./index.html"],
  theme: {
    extend: {
      fontFamily: {
        'open-sans': ['Open Sans', 'Segoe UI'],
        'roboto': ['Roboto', 'Segoe UI'],
      },
      spacing: {
        phone: '320px',
        tablet: '768px',
        hd: '1280px',
        fullhd: '1920px',
        firstSectionHeightPC: '793px',
        firstSectionHeightTablet: '1024px',
        firstSectionHeightPhone: '568px',
        contentMaxWidth: '1140px',
        secondSectionTextMaxWidth: '540px',
        tabletHorizontalPadding: '24px',
        tableFirstCol: '46%',
        tableOtherCols: '27%',
        tableMinWidth: '450px',
        tableRowHeight: '71px',
        speakerAvatarSize: '120px',
        footerHeight: '150px',
        modalWidth: '405px',
      },
      screens: {
        phone: '320px',
        tablet: '768px',
        hd: '1280px',
        fullhd: '1920px',
      },
      colors: {
        firstSectionBg: '#17A2B8',
        buttonColor: '#2F418A',
        buttonColorHover: '#162252',
        grayBg: '#F8F9FA',
        tableBorderColor: '#DEE2E6',
        footerTextColor: '#BABABA',
        modalTextColor: '#9FA3AB',
        inputBorder: '#B5BFC3',
      },
      gridTemplateColumns: {
        table: '46% repeat(2, 27%)'
      },
      boxShadow: {
        modal: '0px 0px 15px 0px #0000001A',
      }
    },
  },
  plugins: [],
}